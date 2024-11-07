using MessagePack;
using StackExchange.Redis;

namespace Aml.Shared.Utilities.Caching;

internal sealed class RedisMultiplexerCacheService : ICacheService
{
    private readonly IConnectionMultiplexer _redis;
    public RedisMultiplexerCacheService(IConnectionMultiplexer redis)
    {
        _redis = redis;
    }


    public async Task<T?> GetAsync<T>(string key)
    {
        var db = _redis.GetDatabase();
        var value = await db.StringGetAsync(key);
        return value.HasValue ? MessagePackSerializer.Deserialize<T>(value!) : default;
    }

    public async Task RemoveAsync(string key)
    {
        var db = _redis.GetDatabase();
        await db.KeyDeleteAsync(key);
    }

    public async Task SetAsync<T>(string key, T value, TimeSpan absoluteExpiration, TimeSpan slidingExpiration)
    {
        var db = _redis.GetDatabase();

        // Use absoluteExpiration for the expiration time.
        // To handle sliding expiration, you'll need to implement a logic to reset the expiration time on access.
        //var serializedValue = JsonSerializer.Serialize(value);
        var serializedValue = MessagePackSerializer.Serialize(value);

        var expirationTime = absoluteExpiration > slidingExpiration ? absoluteExpiration : slidingExpiration;
        await db.StringSetAsync(key, serializedValue, expirationTime);
    }
}
