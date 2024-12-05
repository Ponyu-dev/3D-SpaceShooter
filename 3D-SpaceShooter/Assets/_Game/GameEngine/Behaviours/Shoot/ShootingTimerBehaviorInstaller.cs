// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-05
// <file>: ShootingTimerBehaviorInstaller.cs
// ------------------------------------------------------------------------------

using System;
using _Game.GameEngine.Behaviours.Common;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.Shoot
{
    [Serializable]
    public sealed class ShootingTimerBehaviorInstaller : IBehaviourInstaller
    {
        [SerializeField] private Cycle periodShoot;
        [SerializeField] private AndExpression canShoot;
        [SerializeField] private BaseEvent actionShoot;
        
        public void Install(IEntity entity)
        {
            entity.AddPeriodShoot(periodShoot);
            entity.AddCanShoot(canShoot);
            entity.AddActionShoot(actionShoot);
            
            entity.AddBehaviour<ShootingTimerBehavior>();
        }

        public void CanShootAppend(Func<bool> func)
        {
            canShoot.Append(func);
        }
    }
}