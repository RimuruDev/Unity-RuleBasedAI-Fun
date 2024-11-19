using RimuruDev.Internal.Codebase.Common.AI;
using UnityEngine;

namespace RimuruDev.Internal.Codebase.Common.Characters
{
    public class Character : MonoBehaviour, IActor
    {
        public bool HasEnemy => enemy is { IsAlive: true };
        public bool IsAlive { get; set; }
        public int Team { get; set; }
        public Vector3 Position => transform.position;

        private Character enemy;

        public void AssignEnemy(Character targetEnemy) =>
            enemy = targetEnemy;

        public void Update()
        {
        }
    }
}