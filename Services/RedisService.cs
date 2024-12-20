using StackExchange.Redis;

namespace BlazorRedisDemo.Services;

public class RedisService
{
    private readonly ConnectionMultiplexer _redis;
    private readonly IDatabase _database;

    public RedisService(IConfiguration configuration)
    {
        _redis = ConnectionMultiplexer.Connect(configuration["Redis:ConnectionString"]);
        _database = _redis.GetDatabase();
    }

    public async Task SetAsync(string key, string value, TimeSpan expiration)
    {
        await _database.StringSetAsync(key, value, expiration);
    }

    public async Task<string?> GetAsync(string key)
    {
        return await _database.StringGetAsync(key);
    }
}
