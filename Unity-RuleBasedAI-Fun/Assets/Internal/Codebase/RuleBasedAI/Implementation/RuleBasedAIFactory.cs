using RimuruDev.Internal.Codebase.Common.AI;
using RimuruDev.Internal.Codebase.Common.Services;
using RimuruDev.Internal.Codebase.RuleBasedAi.Core;

namespace RimuruDev.Internal.Codebase.RuleBasedAi.Implementation
{
    public class RuleBasedAIFactory
    {
        private readonly CharactersFactory characterFactory;
        private readonly ActorsRepository actorsRepository;
        private readonly CharactersRepository charactersRepository;

        public RuleBasedAIFactory(
            CharactersFactory characterFactory,
            CharactersRepository charactersRepository,
            ActorsRepository actorsRepository)
        {
            this.charactersRepository = charactersRepository;
            this.characterFactory = characterFactory;
            this.actorsRepository = actorsRepository;
        }

        public IAIActor Create()
        {
            var character = characterFactory.Create();

            var actor = new RuleBasedIaiActor(
                new FindEnemyRule(character, charactersRepository)
            );

            actorsRepository.Register(actor);

            return actor;
        }
    }
}