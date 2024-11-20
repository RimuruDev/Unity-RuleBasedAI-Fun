using RimuruDev.Internal.Codebase.Common.Characters;
using RimuruDev.Internal.Codebase.Common.Services;
using RimuruDev.Internal.Codebase.RuleBasedAi.Core;

namespace RimuruDev.Internal.Codebase.RuleBasedAi.Implementation
{
    public class FindEnemy : IRule
    {
        private readonly Character character;
        private readonly CharactersRepository charactersRepository;

        public bool CanExecute => !character.HasEnemy && charactersRepository.HasEnemy(character);

        public FindEnemy(Character character, CharactersRepository charactersRepository)
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