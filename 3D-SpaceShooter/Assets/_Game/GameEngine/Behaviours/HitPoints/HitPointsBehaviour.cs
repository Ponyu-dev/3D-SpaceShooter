// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-03
// <file>: HitPointsBehaviour.cs
// ------------------------------------------------------------------------------

using Atomic.Elements;
using Atomic.Entities;
using Elementary;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.HitPoints
{
    public sealed class HitPointsBehaviour : IEntityInit, IEntityEnable, IEntityDisable
    {
        private IVariableLimited<int> _hitPoint;
        private IReactiveVariable<bool> _isDead;
        private AndExpression _isTakeDamage;
        
        public void Init(IEntity entity)
        {
            _hitPoint = entity.GetHitPoint();
            _isDead = entity.GetIsDead();
            _isTakeDamage = entity.GetCanTakeDamage();
        }

        public void Enable(IEntity entity)
        {
            entity.GetTakeDamageEvent().Subscribe(OnTakeDamage);
        }

        private void OnTakeDamage(int damage)
        {
            if (!_isTakeDamage.Value)
            {
                Debug.LogError("[HitPointsBehaviour] Is Not Take Damage");
                return;
            }
            
            Debug.Log("[HitPointsBehaviour] OnTakeDamage");

            _hitPoint.Current -= damage;

            if (_hitPoint.Current <= 0)
                _isDead.Value = true;
        }

        public void Disable(IEntity entity)
        {
            entity.GetTakeDamageEvent().Unsubscribe(OnTakeDamage);
        }
    }
}