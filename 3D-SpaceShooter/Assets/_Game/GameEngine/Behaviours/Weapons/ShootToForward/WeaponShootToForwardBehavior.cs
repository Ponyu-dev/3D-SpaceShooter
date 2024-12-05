// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-05
// <file>: WeaponShootToForwardBehavior.cs
// ------------------------------------------------------------------------------

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
        private BaseEvent _actionShoot;
        private Const<Transform> _worldTransform;
        private Const<Transform> _weaponFirePoints;

        //private BulletEntityInstaller _weaponBulletPrefab;
        private ReactiveVector3 _weaponDirectionTarget;
        private Const<float> _weaponDefaultBulletSpeed;
        private Const<int> _weaponDefaultBulletDamage;

        private bool _isPlayerTag;

        public void Init(IEntity entity)
        {
            _isPlayerTag = entity.HasPlayerTag();
            
            _actionShoot = entity.GetActionShoot();
            _worldTransform = SingletonGameContext.Instance.GetWorldTransform();
            _weaponFirePoints = entity.GetWeaponFirePoint();
            _weaponDirectionTarget = entity.GetWeaponDirectionTarget();
            _weaponDefaultBulletSpeed = entity.GetWeaponDefaultBulletSpeed();
            _weaponDefaultBulletDamage = entity.GetWeaponDefaultBulletDamage();
            //_weaponBulletPrefab = entity.GetWeaponBulletPrefab();
        }

        public void Enable(IEntity entity)
        {
            _actionShoot.Subscribe(OnShoot);
        }

        private void OnShoot()
        {
            /*var transformPosition = _weaponFirePoints.Value[0];
            var bullet = NightPool.Spawn(_weaponBulletPrefab, transformPosition.position, Quaternion.identity, _worldTransform.Value);
            bullet.AddTag(_isPlayerTag);
            bullet.InitTransformBehaviour();
            bullet.InitMovementBehaviour(_weaponDefaultBulletSpeed.Value, _weaponDirectionTarget.Value);
            bullet.InitDamage(_weaponDefaultBulletDamage.Value);*/
        }

        public void Disable(IEntity entity)
        {
            _actionShoot.Unsubscribe(OnShoot);
        }
    }
}