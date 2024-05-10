namespace Core.Application.Pipelines.Caching;

public interface ICachableRequest
{
    string CacheKey { get; } //Her bir requesti bir cache key'e bağlayıp o request ile ilgili bir cache oluşturmuş olacağız.
    bool BypassCache { get; } //Test çalışmalarında bypass bilgisi developer için.
    string? CacheGroupKey { get; } //Cache gruplama
    TimeSpan? SlidingExpiration { get; } //Cache'te ne kadar duracak?
}
