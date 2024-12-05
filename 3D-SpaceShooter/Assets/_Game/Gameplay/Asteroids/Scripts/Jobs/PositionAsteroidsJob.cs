// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-03
// <file>: RotateAsteroidsJob.cs
// ------------------------------------------------------------------------------

using _Game.Gameplay.Asteroids.Scripts.Data;
using Unity.Burst;
using Unity.Collections;
using UnityEngine.Jobs;

namespace _Game.Gameplay.Asteroids.Scripts.Jobs
{
    [BurstCompile]
    public struct PositionAsteroidsJob : IJobParallelForTransform
    {
        [ReadOnly] public NativeArray<AsteroidData> AsteroidDataArray;
        [WriteOnly] public float DeltaTime;

        public void Execute(int index, TransformAccess transform)
        {
            var data = AsteroidDataArray[index];
            var newPosition = transform.position + data.PositionSpeed * DeltaTime * data.PositionDirection;
            transform.position = newPosition;
        }
    }
}