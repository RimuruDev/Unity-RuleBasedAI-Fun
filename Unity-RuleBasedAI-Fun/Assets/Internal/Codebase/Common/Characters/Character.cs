using RimuruDev.Internal.Codebase.Common.AI;
using UnityEngine;

namespace RimuruDev.Internal.Codebase.Common.Characters
{
    public class Character : MonoBehaviour, IAIActor
    {
        public bool HasEnemy => enemy is { IsAlive: true };
        public bool IsAlive { get; set; } = true; 
        public Vector3 Position => transform.position;
        public int Team { get; private set; }

        [SerializeField] private Attack attack;
        [SerializeField] private Movement movement;
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

        public bool CloseEnoughToAttack => 
            Vector3.SqrMagnitude(Position - enemy.Position) <= Mathf.Pow(attack.AttackDistance, 2f );

        public void MoveToEnemy() => 
            movement.MoveTo(enemy.Position);
    }
}