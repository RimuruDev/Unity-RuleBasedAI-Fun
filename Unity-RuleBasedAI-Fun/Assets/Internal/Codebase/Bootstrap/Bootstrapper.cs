using System;
using RimuruDev.Internal.Codebase.Common.Characters;
using RimuruDev.Internal.Codebase.Common.Services;
using UnityEngine;

namespace RimuruDev.Internal.Codebase.Bootstrap
{
    public class Bootstrapper : MonoBehaviour
    {
        private ActorsRepository actorsRepository;
        private CharactersRepository charactersRepository;
        private CharactersFactory characterFactory;
        private RuleBasedAIFactory ruleBasedFactory;

        private void Start()
        {
            actorsRepository = new ActorsRepository();
            charactersRepository = new CharactersRepository();

            characterFactory = new CharactersFactory();
            ruleBasedFactory = new RuleBasedAIFactory(characterFactory, actorsRepository);
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