// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: VictoryKillThresholdSystemInstaller.cs
// ------------------------------------------------------------------------------

using System;
using Atomic.Contexts;
using Elementary;
using UnityEngine;

namespace _Game.Gameplay.GameContext.System.VictoryKillThreshold
{
    [Serializable]
    public sealed class VictoryKillThresholdSystemInstaller : IContextInstaller
    {
        [SerializeField] private IntVariableLimited victoryKillThreshold;
        
        public void Install(IContext context)
        {
            context.AddVictoryKillThreshold(victoryKillThreshold);
            context.AddSystem<VictoryKillThresholdSystem>();
        }
    }
}