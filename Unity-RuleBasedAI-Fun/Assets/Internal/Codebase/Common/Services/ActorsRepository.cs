using System.Collections.Generic;
using System.Linq;
using RimuruDev.Internal.Codebase.Common.AI;
using RimuruDev.Internal.Codebase.RuleBasedAI.Core;

namespace RimuruDev.Internal.Codebase.Common.Services
{
    public class ActorsRepository : IRepository<RuleBasedIaiActor>
    {
        public IEnumerable<IAIActor> All => actors;
        private readonly List<IAIActor> actors = new();

        public void Register(RuleBasedIaiActor actor)
        {
            actors.Add(actor);
        }

        public void Unregister(RuleBasedIaiActor actor)
        {
            if (actors.Contains(actor))
                actors.Remove(actor);
        }

        public void UnregisterAll()
        {
            foreach (var actor in actors.ToList().Where(actor => actors.Contains(actor)))
                actors.Remove(actor);

            actors.Clear();
        }
    }
}