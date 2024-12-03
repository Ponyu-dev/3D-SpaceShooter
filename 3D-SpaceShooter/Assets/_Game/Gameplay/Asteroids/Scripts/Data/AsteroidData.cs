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

        public AsteroidData(Vector3 rotationAxis, float rotationSpeed)
        {
            RotationAxis = rotationAxis;
            RotationSpeed = rotationSpeed;
        }
    }
}