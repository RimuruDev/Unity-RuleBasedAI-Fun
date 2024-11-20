using System;
using UnityEngine;
using UnityEngine.AI;

namespace RimuruDev.Internal.Codebase.Common.Characters
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent navMeshAgent;
        [SerializeField] private float updatePathCooldown;
        [SerializeField] private float currentCooldown;

        private bool IsCooldown => currentCooldown <= 0f;

        private void Update() =>
            currentCooldown = Mathf.Max(currentCooldown - Time.deltaTime, 0f);

        public void MoveTo(Vector3 target)
        {
            if (navMeshAgent.destination == target || IsCooldown)
                return;

            navMeshAgent.SetDestination(target);
 
            currentCooldown = updatePathCooldown;
        }
    }
}