// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-03
// <file>: HitPointsBehaviourInstaller.cs
// ------------------------------------------------------------------------------

using System;
using _Game.GameEngine.Behaviours.Common;
using Atomic.Elements;
using Atomic.Entities;
using Elementary;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.HitPoints
{
    [Serializable]
    public sealed class HitPointsBehaviourInstaller : IBehaviourInstaller
    {
        [SerializeField] private ReactiveBool isDead;
        [SerializeField] private IntVariableLimited hitPoint;
        [SerializeField] private AndExpression canTakeDamage;
        [SerializeField] private BaseEvent<int> takeDamageEvent;

        public Func<bool> IsNotDead() => () => !isDead.Value;

        public void Install(IEntity entity)
        {
            entity.AddIsDead(isDead);
            entity.AddHitPoint(hitPoint);
            entity.AddCanTakeDamage(canTakeDamage);
            entity.AddTakeDamageEvent(takeDamageEvent);

            canTakeDamage.Append(member: () => !isDead.Value);

            entity.AddBehaviour<HitPointsBehaviour>();
        }
    }
}