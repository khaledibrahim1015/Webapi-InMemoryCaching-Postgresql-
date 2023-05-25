using System.Runtime.Caching;

namespace apiCaching;

public class CacheService : ICacheService
{
    private ObjectCache _memoryCache = MemoryCache.Default;


    public T GetData<T>(string key)
    {
        try
        {
                T item = (T)_memoryCache.Get(key);
                return item;
        }
        catch (Exception ex)
        {
            
            throw;
        }

    }

    public object RemoveData(string key)
    {
        
        var res = true;

        if (!string.IsNullOrEmpty(key))
            return _memoryCache.Remove(key);
        else
            res= false;


        return res;

    }

    public bool SetData<T>(string key, T value, DateTimeOffset expirationTime)
    {
        
        var res = true ;


        try
        {
            if(! string.IsNullOrEmpty(key))
                _memoryCache.Set(key , value, expirationTime);
            else
            res= false;

            return res;
            

        }
        catch (Exception ex)
        {
            
            throw;
        }




    }
}