using UnityEngine;

namespace RimuruDev.Internal.Codebase.Common.Character
{
    public class Character : MonoBehaviour
    {
        public bool HasEnemy => enemy is { IsAlive: true };
        public bool IsAlive { get; set; }
        public int Team { get; set; }
        public Vector3 Position => transform.position;

        private Character enemy;

        public void AssignEnemy(Character targetEnemy) =>
            enemy = targetEnemy;
    }
}