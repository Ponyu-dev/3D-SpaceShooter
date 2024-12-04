// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-04
// <file>: SpawnAsteroidData.cs
// ------------------------------------------------------------------------------

using System;
using Atomic.Elements;
using UnityEngine;

namespace _Game.Gameplay.Asteroids.Scripts.Data
{
    [Serializable]
    public struct SpawnAsteroidData
    {
        public GameObject prefab;
        public Bounds spawnArea;
        public Cycle spawnCycle;
    }
}