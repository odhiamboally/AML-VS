namespace Aml.Shared.Configurations.Caching;

public class CacheSetting
{
    public string CacheType { get; set; } = string.Empty;
    public string CacheKeyPrefix { get; set; } = "IB_";
    public RedisSetting? Redis { get; set; }
    public AzureCacheSetting? Azure { get; set; }
    public ElastiCacheSetting? Aws { get; set; }
}
