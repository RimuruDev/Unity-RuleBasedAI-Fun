using RimuruDev.Internal.Codebase.Common.Characters;
using UnityEngine;

namespace RimuruDev.Internal.Codebase.Common.Services
{
    public class CharactersFactory
    {
        private const string PathToCharacter = "Character";
        private readonly CharactersRepository charactersRepository;

        public CharactersFactory(CharactersRepository charactersRepository) =>
            this.charactersRepository = charactersRepository;

        public Character Create()
        {
            var prefab = Resources.Load<Character>(PathToCharacter);

            var instance = Object.Instantiate(prefab);

            charactersRepository.Register(instance);

            return instance;
        }
    }
}