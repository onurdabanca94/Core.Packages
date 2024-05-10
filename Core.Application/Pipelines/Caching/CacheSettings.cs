namespace Core.Application.Pipelines.Caching;

//appsettings dosyasında set edilebilecek bir class
public class CacheSettings
{
    public int SlidingExpiration { get; set; }
}