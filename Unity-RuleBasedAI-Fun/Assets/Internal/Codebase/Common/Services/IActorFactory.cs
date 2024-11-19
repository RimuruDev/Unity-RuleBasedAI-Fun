using RimuruDev.Internal.Codebase.Common.AI;

namespace RimuruDev.Internal.Codebase.Common.Services
{
    public interface IActorFactory
    {
        public IActor Create();
    }
}