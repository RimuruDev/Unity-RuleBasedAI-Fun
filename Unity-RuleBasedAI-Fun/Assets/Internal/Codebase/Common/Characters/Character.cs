using RimuruDev.Internal.Codebase.Common.AI;
using UnityEngine;

namespace RimuruDev.Internal.Codebase.Common.Characters
{
    public class Character : MonoBehaviour, IAIActor
    {
        public bool HasEnemy => enemy is { IsAlive: true };
        public bool IsAlive { get; set; }
        public Vector3 Position => transform.position;
        public int Team { get; private set; }

        private Character enemy;

        public void Constructor(int team)
        {
            Team = team;
        }

        public void AssignEnemy(Character targetEnemy)
        {
            enemy = targetEnemy;
        }

        public void Update()
        {
        }
    }
}