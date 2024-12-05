// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-05
// <file>: WeaponShootToForwardBehaviorInstaller.cs
// ------------------------------------------------------------------------------

using System;
using _Game.GameEngine.Behaviours.Common;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.Weapons.ShootToForward
{
    [Serializable]
    public sealed class WeaponShootToForwardBehaviorInstaller : IBehaviourInstaller
    {
        //[SerializeField] private BulletEntityInstaller prefabBullet;
        [SerializeField] private Const<Transform> firePoint;
        [SerializeField] private ReactiveVector3 directionShoot = new(Vector3.forward);
        [SerializeField] private Const<float> bulletSpeed = new(10f);
        [SerializeField] private Const<int> bulletDamage = new(10);
        
        public void Install(IEntity entity)
        {
            //entity.AddWeaponBulletPrefab(prefabBullet);
            entity.AddWeaponFirePoint(firePoint);
            entity.AddWeaponDirectionTarget(directionShoot);
            entity.AddWeaponDefaultBulletSpeed(bulletSpeed);
            entity.AddWeaponDefaultBulletDamage(bulletDamage);

            entity.AddBehaviour<WeaponShootToForwardBehavior>();
        }
    }
}