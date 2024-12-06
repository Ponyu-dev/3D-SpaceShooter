// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-05
// <file>: WeaponShootToForwardBehavior.cs
// ------------------------------------------------------------------------------

using _Game.Gameplay.Bullets.Scripts;
using _Game.Gameplay.GameContext;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using NTC.Pool;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.Weapons.ShootToForward
{
    public sealed class WeaponShootToForwardBehavior : IEntityInit, IEntityEnable, IEntityDisable
    {
        private BaseEvent _eventShoot;
        private Const<Transform> _worldTransform;
        private Const<Transform> _weaponFirePoint;

        private BulletEntityInstaller _weaponBulletPrefab;
        private ReactiveVector3 _weaponDirectionTarget;
        private Const<float> _weaponDefaultBulletSpeed;
        private Const<int> _weaponDefaultBulletDamage;

        public void Init(IEntity entity)
        {
            _eventShoot = entity.GetActionShoot();
            _worldTransform = SingletonGameContext.Instance.GetWorldTransform();
            _weaponFirePoint = entity.GetWeaponFirePoint();
            _weaponDirectionTarget = entity.GetWeaponDirectionTarget();
            _weaponDefaultBulletSpeed = entity.GetWeaponDefaultBulletSpeed();
            _weaponDefaultBulletDamage = entity.GetWeaponDefaultBulletDamage();
            _weaponBulletPrefab = entity.GetWeaponBulletPrefab();
        }

        public void Enable(IEntity entity)
        {
            _eventShoot.Subscribe(OnShoot);
        }

        private void OnShoot()
        {
            var bullet = NightPool.Spawn(_weaponBulletPrefab, _weaponFirePoint.Value.position, Quaternion.identity, _worldTransform.Value);
            
            bullet.InitTransformBehaviour();
            bullet.InitMovementBehaviour(_weaponDefaultBulletSpeed.Value, _weaponDirectionTarget.Value);
            bullet.InitDamage(_weaponDefaultBulletDamage.Value);
        }

        public void Disable(IEntity entity)
        {
            _eventShoot.Unsubscribe(OnShoot);
        }
    }
}