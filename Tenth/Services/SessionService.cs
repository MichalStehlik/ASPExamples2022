namespace Tenth.Services
{
    public class SessionStorage<T>
    {
        private readonly IHttpContextAccessor _hca;
        private ISession _session => _hca.HttpContext.Session;
        public SessionStorage(IHttpContextAccessor hca)
        {
            _hca = hca;
        }
        public T LoadOrCreate(string key)
        {
            T result = _session.Get<T>(key);
            if (typeof(T).IsClass && result == null) result = (T)Activator.CreateInstance(typeof(T));
            return result;
        }
        public void Save(string key, T data)
        {
            _session.Set(key, data);
        }
    }
}
