using RimuruDev.Internal.Codebase.Common.AI;

namespace RimuruDev.Internal.Codebase.Common.Services
{
    public class RuleBasedAIFactory : IActorFactory
    {
        private readonly CharactersFactory characterFactory;
        private readonly ActorsRepository actorsRepository;

        public RuleBasedAIFactory(CharactersFactory characterFactory, ActorsRepository actorsRepository)
        {
            this.characterFactory = characterFactory;
            this.actorsRepository = actorsRepository;
        }

        public IActor Create()
        {
            var character = characterFactory.Create();



            return character; 
        }
    }
}