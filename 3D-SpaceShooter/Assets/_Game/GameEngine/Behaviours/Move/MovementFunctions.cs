// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-02
// <file>: MovementFunctions.cs
// ------------------------------------------------------------------------------

using Unity.Burst;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.Move
{
    [BurstCompile]
    public static class MovementFunctions
    {
        [BurstCompile]
        public static void MoveStep(
            in Vector3 position,
            in Vector3 direction,
            in float speed,
            in float deltaTime,
            out Vector3 newPosition
        )
        {
            newPosition = position + speed * deltaTime * direction;
        }
        
        [BurstCompile]
        public static void BoundaryMoveStep(
            in Vector3 position,
            in Vector3 direction,
            in float speed,
            in float deltaTime,
            in Vector3 minBounds,
            in Vector3 maxBounds,
            out Vector3 newPosition
        )
        {
            MoveStep(position, direction, speed, deltaTime,
                out var pos);
             
            newPosition = new Vector3(
                Mathf.Clamp(pos.x, minBounds.x, maxBounds.x),
                Mathf.Clamp(pos.y, minBounds.y, maxBounds.y),
                0);
        }
    }
}