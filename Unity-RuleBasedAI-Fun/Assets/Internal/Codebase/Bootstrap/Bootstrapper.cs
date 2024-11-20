using System;
using RimuruDev.Internal.Codebase.Common.Characters;
using RimuruDev.Internal.Codebase.Common.Services;
using RimuruDev.Internal.Codebase.RuleBasedAi.Implementation;
using UnityEngine;

namespace RimuruDev.Internal.Codebase.Bootstrap
{
    public class Bootstrapper : MonoBehaviour
    {
        private CharactersFactory characterFactory;
        private CharactersRepository charactersRepository;

        private RuleBasedAIFactory ruleBasedFactory;
        private ActorsRepository actorsRepository;

        private void Start()
        {
            characterFactory = new CharactersFactory();
            charactersRepository = new CharactersRepository();

            actorsRepository = new ActorsRepository();
            ruleBasedFactory = new RuleBasedAIFactory(characterFactory, charactersRepository,actorsRepository);
        }

        private void Update()
        {
            foreach (var character in actorsRepository.All)
                character.Update();
        }

        [NaughtyAttributes.Button]
        private void CreateCharacter()
        {
            characterFactory.Create();
        }
    }
}