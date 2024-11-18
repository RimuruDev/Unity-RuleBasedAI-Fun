using RimuruDev.Internal.Codebase.Common.Character;
using RimuruDev.Internal.Codebase.RuleBasedAI.Core;

namespace RimuruDev.Internal.Codebase.RuleBasedAI.Implementation
{
    public class FindEnemyRule : IRule
    {
        private readonly Character character;
        private readonly CharactersRepository charactersRepository;

        public bool CanExecute => !character.HasEnemy && charactersRepository.HasEnemy(character);

        public FindEnemyRule(Character character, CharactersRepository charactersRepository)
        {
            this.character = character;
            this.charactersRepository = charactersRepository;
        }

        public void Execute()
        {
            var enemy = charactersRepository.GetClosestEnemy(character);
            character.AssignEnemy(enemy);
        }
    }
}