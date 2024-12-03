// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-03
// <file>: HitPointsBehaviour.cs
// ------------------------------------------------------------------------------

using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.HitPoints
{
    public sealed class HitPointsBehaviour : IEntityInit, IEntityEnable, IEntityDisable
    {
        private IReactiveValue<int> _maxHp;
        private IReactiveVariable<int> _currentHp;
        private IReactiveVariable<bool> _isDead;
        private AndExpression _isTakeDamage;
        
        public void Init(IEntity entity)
        {
            _isDead = entity.GetIsDead();
            _maxHp = entity.GetMaxHp();
            _currentHp = entity.GetCurrentHp();
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
            
            var newCurrentHp = _currentHp.Value - damage;
            _currentHp.Value = Mathf.Clamp(newCurrentHp, 0, _maxHp.Value);

            if (_currentHp.Value <= 0)
                _isDead.Value = true;
        }

        public void Disable(IEntity entity)
        {
            entity.GetTakeDamageEvent().Unsubscribe(OnTakeDamage);
        }
    }
}