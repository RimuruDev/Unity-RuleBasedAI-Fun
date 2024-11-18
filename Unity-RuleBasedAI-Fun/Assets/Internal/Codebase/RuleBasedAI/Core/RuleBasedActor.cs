using RimuruDev.Internal.Codebase.Common.AI;

namespace RimuruDev.Internal.Codebase.RuleBasedAI.Core
{
    public class RuleBasedActor : IActor
    {
        private readonly IRule[] rules;

        public RuleBasedActor(params IRule[] rules) =>
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