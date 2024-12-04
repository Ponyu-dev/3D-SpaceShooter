// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-04
// <file>: AsteroidsGizmos.cs
// ------------------------------------------------------------------------------

using UnityEngine;

namespace _Game.Gameplay.Asteroids.Scripts
{
    public sealed class AsteroidsGizmos : MonoBehaviour
    {
        public Color spawnPositionColor;
        public Vector3 spawnPosition;
        
        public Color directionPositionColor;
        public Vector3 directionPosition;

        private void OnDrawGizmos()
        {
            Gizmos.color = spawnPositionColor;
            Gizmos.DrawSphere(spawnPosition, 1);
            
            Gizmos.color = directionPositionColor;
            Gizmos.DrawLine(transform.position, directionPosition);
        }
    }
}