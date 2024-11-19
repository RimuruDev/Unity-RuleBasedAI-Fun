using System.Collections.Generic;
using RimuruDev.Internal.Codebase.Common.AI;

namespace RimuruDev.Internal.Codebase.Common.Services
{
    public class ActorsRepository
    {
        public IEnumerable<IActor> All => actors;
        private readonly List<IActor> actors = new();
    }
}