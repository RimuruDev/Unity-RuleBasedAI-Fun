using RimuruDev.Internal.Codebase.Common.AI;
using UnityEngine;
using RimuruDev.Internal.Codebase.Common.Characters;

namespace RimuruDev.Internal.Codebase.Common.Services
{
    public class CharactersFactory
    {
        private const float SpawnRadius = 20f;
        private const int MinTeamCount = 0;
        private const int MaxTeamCount = 4;
        private const string PathToCharacter = "Character";
        private const string CharacterRootTag = "Character/Root";

        private static float RandomRadius => Random.Range(SpawnRadius, -SpawnRadius);
        private static int RandomTeam => Random.Range(MinTeamCount, MaxTeamCount);

        private readonly CharactersRepository charactersRepository;

        public CharactersFactory(CharactersRepository charactersRepository) =>
            this.charactersRepository = charactersRepository;

        public Character Create()
        {
            var prefab = Resources.Load<Character>(PathToCharacter);
            var root = GameObject.FindGameObjectWithTag(CharacterRootTag)?.transform;

            var position = new Vector3(RandomRadius, 0f, RandomRadius);
            var instance = Object.Instantiate(prefab, position, Quaternion.identity, root);

            instance.Constructor(team: RandomTeam);

            charactersRepository.Register(instance);

            return instance;
        }
    }
}