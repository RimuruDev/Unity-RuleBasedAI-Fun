using RimuruDev.Internal.Codebase.Common.AI;
using UnityEngine;
using RimuruDev.Internal.Codebase.Common.Characters;

namespace RimuruDev.Internal.Codebase.Common.Services
{
    public class CharactersFactory : IActorFactory
    {
        private const float SpawnRadius = 20f;
        private const string PathToCharacter = "Character";
        private const string CharacterRootTag = "Character/Root";

        private static float RandomRadius => Random.Range(SpawnRadius, -SpawnRadius);

        public IActor Create()
        {
            var prefab = Resources.Load<Character>(PathToCharacter);
            var root = GameObject.FindGameObjectWithTag(CharacterRootTag)?.transform;

            var position = new Vector3(RandomRadius, 0f, RandomRadius);
            var instance = Object.Instantiate(prefab, position, Quaternion.identity, root);

            return instance;
        }
    }
}