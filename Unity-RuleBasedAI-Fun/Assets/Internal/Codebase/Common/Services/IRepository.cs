using System.Collections.Generic;

namespace RimuruDev.Internal.Codebase.Common.Services
{
    public interface IRepository<T>
    {
        public IEnumerable<T> All { get; }
        public void Register(T target);
        public void Unregister(T target);
        public void UnregisterAll();
    }
}