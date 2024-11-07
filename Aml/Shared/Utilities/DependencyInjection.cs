using Aml.Channels.IB.Messaging.Consumers;
using Aml.Channels.IB.Utilities.Jobs;
using Aml.Shared.Configurations.Api;
using Aml.Shared.Configurations.Caching;
using Aml.Shared.Configurations.Pagination;
using Aml.Shared.Messaging.RabbitMQ;
using Aml.Shared.Utilities.Caching;
using Carter;
using FluentValidation;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Quartz;
using Refit;
using StackExchange.Redis;

namespace Aml.Shared.Utilities;

public static class DependencyInjection
{
    public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        var assembly = typeof(Program).Assembly;

        var cacheSettings = new CacheSetting();
        configuration.GetSection("CacheSettings").Bind(cacheSettings);
        services.AddSingleton(cacheSettings);
        CacheKeyGenerator.Configure(cacheSettings);

        var paginationSetting = new PaginationSetting();
        configuration.GetSection("PaginationSetting").Bind(paginationSetting);
        services.AddSingleton(paginationSetting);

        var connString = configuration.GetConnectionString("KHS");
        services.AddDbContext<DbContext>(options => options.UseSqlServer(connString!));

        var refitSettings = new RefitSettings(); // Customize if needed
        services.AddSingleton(typeof(IApiClientFactory<>), typeof(ApiClientFactory<>));

        // MassTransit and RabbitMQ configuration
        services.AddScoped<IMessageProducer, RabbitMqBusMessageProducer>();
        services.AddScoped<IMessageProducer, RabbitMqBusControlMessageProducer>();
        services.AddSingleton<IMessageConsumer, RabbitMqBusControlMessageConsumer>();
        services.AddMassTransit(x =>
        {
            x.AddConsumers(assembly);

            x.UsingRabbitMq((context, cfg) =>
            {
                //cfg.Host("host.docker.internal", "/", h =>
                //{
                //    h.Username("guest");
                //    h.Password("guest");

                //    h.UseSsl(s =>
                //    {
                //        s.Protocol = SslProtocols.Tls12; // Ensure correct SSL protocol
                //        s.ServerName = "localhost"; // Match the server name to certificate's CN or subject alternative name
                //        s.CertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true; // Use this for dev; otherwise, use proper validation.
                //    });
                //});

                // Configure individual consumers with their own endpoints
                cfg.ReceiveEndpoint("queue_for_ConsumerA", e =>
                {
                    e.ConfigureConsumer<IBCustomConsumer>(context);
                });

                // Add more endpoints as needed for additional consumers


                //// Use a convention to automatically assign each consumer its own queue
                //cfg.ConfigureEndpoints(context);

                //// Example: Use shared queue for specific consumers
                //cfg.ReceiveEndpoint("shared_queue", e =>
                //{
                //    e.ConfigureConsumer<ConsumerShared1>(context);
                //    e.ConfigureConsumer<ConsumerShared2>(context);
                //});

                //// Dynamic queue names based on environment
                //cfg.ReceiveEndpoint($"unique_queue_{Environment.GetEnvironmentVariable("ENV_NAME")}", e =>
                //{
                //    e.ConfigureConsumer<ConsumerEnvSpecific>(context);
                //});


            });
        });

        services.Configure<QuartzOptions>(configuration.GetSection("Quartz"));

        // if you are using persistent job store, you might want to alter some options
        services.Configure<QuartzOptions>(options =>
        {
            options.Scheduling.IgnoreDuplicates = true; // default: false
            options.Scheduling.OverWriteExistingData = true; // default: true
        });

        services.AddQuartz(q =>
        {
            var jobKey = new JobKey("CustomJob");
            q.AddJob<CustomJob>(opts => opts
                .WithIdentity(jobKey));

            q.AddTrigger(opts => opts
                .ForJob(jobKey)
                .WithIdentity("CustomJob-trigger")
                //.WithCronSchedule("0 0 * * * ?")); // Every hour
                .WithSimpleSchedule(x => x
                    .WithInterval(TimeSpan.FromMinutes(5))
                    .RepeatForever())
            );

        });

        //Add the Quartz hosted service
        services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);

        switch (cacheSettings.CacheType)
        {
            case { } type when type.Equals("redis", StringComparison.OrdinalIgnoreCase):

                services.AddSingleton<IConnectionMultiplexer>(_ => ConnectionMultiplexer.Connect(cacheSettings.Redis!.Configuration!));

                // Register the IDatabase from the connection multiplexer
                services.AddScoped(sp =>
                {
                    var connectionMultiplexer = sp.GetRequiredService<IConnectionMultiplexer>();
                    return connectionMultiplexer.GetDatabase();
                });

                services.AddStackExchangeRedisCache(options =>
                {
                    options.Configuration = cacheSettings.Redis!.Configuration;
                    options.InstanceName = cacheSettings.Redis.InstanceName;
                });
                services.AddSingleton<ICacheService, RedisMultiplexerCacheService>();
                services.AddSingleton<ICacheService, RedisCacheService>();
                break;

            case { } type when type.Equals("azure", StringComparison.OrdinalIgnoreCase):
                services.AddStackExchangeRedisCache(options =>
                {
                    options.Configuration = cacheSettings.Azure!.ConnectionString;
                });
                services.AddSingleton<ICacheService, AzureCacheService>();
                break;

            case { } type when type.Equals("aws", StringComparison.OrdinalIgnoreCase):
                services.AddStackExchangeRedisCache(options =>
                {
                    options.Configuration = cacheSettings.Aws!.Endpoint;
                });
                services.AddSingleton<ICacheService, ElastiCacheService>();
                break;

            default:
                services.AddMemoryCache();
                services.AddSingleton<ICacheService, InMemoryCacheService>();
                break;
        }

        
        services.AddCarter();
        services.AddMediatR(config => config.RegisterServicesFromAssembly(assembly));
        services.AddValidatorsFromAssembly(assembly);

        //services.AddScoped<IServiceManager, ServiceManager>();

        //services.AddScoped<IUnitOfWork, UnitOfWork>();
        //services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));

        return services;
    }
}
