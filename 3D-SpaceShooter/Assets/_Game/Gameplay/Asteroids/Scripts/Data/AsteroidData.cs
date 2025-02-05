// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-03
// <file>: AsteroidData.cs
// ------------------------------------------------------------------------------

using UnityEngine;

namespace _Game.Gameplay.Asteroids.Scripts.Data
{
    public struct AsteroidData
    {
        public Vector3 RotationAxis { get; private set; }
        public float RotationSpeed { get; private set; }
        public Vector3 PositionDirection { get; private set; }
        public float PositionSpeed { get; private set; }

        public AsteroidData(Vector3 rotationAxis, float rotationSpeed, Vector3 positionDirection, float positionSpeed)
        {
            RotationAxis = rotationAxis;
            RotationSpeed = rotationSpeed;
            PositionDirection = positionDirection;
            PositionSpeed = positionSpeed;
        }
    }
}