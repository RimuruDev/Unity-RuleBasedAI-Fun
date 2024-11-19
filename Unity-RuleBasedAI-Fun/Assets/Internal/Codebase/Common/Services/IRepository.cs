namespace RimuruDev.Internal.Codebase.Common.Services
{
    public interface IRepository<in T>
    {
        public void Register(T target);
        public void Unregister(T target);
        public void UnregisterAll();
    }
}