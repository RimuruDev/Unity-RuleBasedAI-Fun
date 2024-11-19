using UnityEngine;
using RimuruDev.Internal.Codebase.Common.Characters;

namespace RimuruDev.Internal.Codebase.Common.Services
{
    public class CharactersFactory
    {
        private const float SpawnRadius = 20f;
        private const string PathToCharacter = "Character";
        private const string CharacterRootTag = "Character/Root";

        private readonly CharactersRepository charactersRepository;
        private static float RandomRadius => Random.Range(SpawnRadius, -SpawnRadius);

        public CharactersFactory(CharactersRepository charactersRepository) =>
            this.charactersRepository = charactersRepository;

        public Character Create()
        {
            var prefab = Resources.Load<Character>(PathToCharacter);
            var root = GameObject.FindGameObjectWithTag(CharacterRootTag)?.transform;

            var position = new Vector3(RandomRadius, 0f, RandomRadius);

            var instance = Object.Instantiate(prefab, position, Quaternion.identity, root);

            charactersRepository.Register(instance);

            return instance;
        }
    }
}