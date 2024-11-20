using RimuruDev.Internal.Codebase.Common.AI;

namespace RimuruDev.Internal.Codebase.RuleBasedAi.Core
{
    public class RuleBasedIaiActor : IAIActor
    {
        private readonly IRule[] rules;

        public RuleBasedIaiActor(params IRule[] rules) =>
            this.rules = rules;

        public void Update()
        {
            foreach (var rule in rules)
            {
                if (!rule.CanExecute)
                    continue;

                rule.Execute();
                return;
            }
        }
    }
}