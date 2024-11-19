using System.Collections.Generic;
using NUnit.Framework;
using RimuruDev.Internal.Codebase.Common.Characters;
using UnityEngine;

namespace RimuruDev.Internal.Codebase.Common.Services
{
    public class CharactersRepository
    {
        private readonly List<Character> characters = new();

        public void Register(Character character) =>
            characters.Add(character);

        public void Unregister(Character character)
        {
            if (characters.Contains(character))
                characters.Remove(character);
        }

        public int ReadCapacity() =>
            characters.Count;

        public bool HasEnemy(Character forCharacter)
        {
            foreach (var character in characters)
            {
                if (character.Team != forCharacter.Team)
                    return true;
            }

            return false;
        }

        public Character GetClosestEnemy(Character forCharacter)
        {
            var closestSqrDistance = float.MaxValue;
            Character closestEnemy = null;

            foreach (var character in characters)
            {
                var sqrDistance = Vector3.SqrMagnitude(character.Position - forCharacter.Position);

                if (sqrDistance < closestSqrDistance && character.Team != forCharacter.Team)
                {
                    closestSqrDistance = sqrDistance;
                    closestEnemy = character;
                }
            }

            Assert.IsNotNull(closestEnemy);

            return closestEnemy;
        }
    }
}