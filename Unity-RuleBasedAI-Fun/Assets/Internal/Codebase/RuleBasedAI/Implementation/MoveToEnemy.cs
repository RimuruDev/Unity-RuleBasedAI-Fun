using RimuruDev.Internal.Codebase.Common.Characters;
using RimuruDev.Internal.Codebase.RuleBasedAi.Core;

namespace RimuruDev.Internal.Codebase.RuleBasedAi.Implementation
{
    public class MoveToEnemy : IRule
    {
        private readonly Character character;

        public bool CanExecute => character.HasEnemy 
                                  && !character.CloseEnoughToAttack;

        public MoveToEnemy(Character character) => 
            this.character = character;

        public void Execute() => 
            character.MoveToEnemy();
    }
}