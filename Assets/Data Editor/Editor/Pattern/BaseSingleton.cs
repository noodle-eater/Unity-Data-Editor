public class BaseSingleton<T> where T : class, new()
{
    private static T _instance = null;
    private static readonly object padlock = new object();
    public static T Instance
    {
        get
        {
            lock (padlock)
            {
                if (_instance == null)
                {
                    _instance = new T();
                }
            }
            return _instance;
        }
    }
}
