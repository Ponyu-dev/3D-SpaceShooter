/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Entities;
using System.Runtime.CompilerServices;
using Atomic.Elements;
using Elementary;
using _Game.Gameplay.Bullets.Scripts;

namespace Atomic.Entities
{
    public static class WeaponAPI
    {
        ///Keys
        public const int WeaponFirePoint = 23; // Const<Transform>
        public const int WeaponDirectionTarget = 24; // ReactiveVector3
        public const int WeaponDefaultBulletSpeed = 25; // Const<float>
        public const int WeaponDefaultBulletDamage = 26; // Const<int>
        public const int WeaponBulletPrefab = 27; // BulletEntityInstaller


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Const<Transform> GetWeaponFirePoint(this IEntity obj) => obj.GetValue<Const<Transform>>(WeaponFirePoint);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetWeaponFirePoint(this IEntity obj, out Const<Transform> value) => obj.TryGetValue(WeaponFirePoint, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddWeaponFirePoint(this IEntity obj, Const<Transform> value) => obj.AddValue(WeaponFirePoint, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasWeaponFirePoint(this IEntity obj) => obj.HasValue(WeaponFirePoint);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelWeaponFirePoint(this IEntity obj) => obj.DelValue(WeaponFirePoint);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWeaponFirePoint(this IEntity obj, Const<Transform> value) => obj.SetValue(WeaponFirePoint, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVector3 GetWeaponDirectionTarget(this IEntity obj) => obj.GetValue<ReactiveVector3>(WeaponDirectionTarget);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetWeaponDirectionTarget(this IEntity obj, out ReactiveVector3 value) => obj.TryGetValue(WeaponDirectionTarget, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddWeaponDirectionTarget(this IEntity obj, ReactiveVector3 value) => obj.AddValue(WeaponDirectionTarget, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasWeaponDirectionTarget(this IEntity obj) => obj.HasValue(WeaponDirectionTarget);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelWeaponDirectionTarget(this IEntity obj) => obj.DelValue(WeaponDirectionTarget);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWeaponDirectionTarget(this IEntity obj, ReactiveVector3 value) => obj.SetValue(WeaponDirectionTarget, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Const<float> GetWeaponDefaultBulletSpeed(this IEntity obj) => obj.GetValue<Const<float>>(WeaponDefaultBulletSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetWeaponDefaultBulletSpeed(this IEntity obj, out Const<float> value) => obj.TryGetValue(WeaponDefaultBulletSpeed, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddWeaponDefaultBulletSpeed(this IEntity obj, Const<float> value) => obj.AddValue(WeaponDefaultBulletSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasWeaponDefaultBulletSpeed(this IEntity obj) => obj.HasValue(WeaponDefaultBulletSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelWeaponDefaultBulletSpeed(this IEntity obj) => obj.DelValue(WeaponDefaultBulletSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWeaponDefaultBulletSpeed(this IEntity obj, Const<float> value) => obj.SetValue(WeaponDefaultBulletSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Const<int> GetWeaponDefaultBulletDamage(this IEntity obj) => obj.GetValue<Const<int>>(WeaponDefaultBulletDamage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetWeaponDefaultBulletDamage(this IEntity obj, out Const<int> value) => obj.TryGetValue(WeaponDefaultBulletDamage, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddWeaponDefaultBulletDamage(this IEntity obj, Const<int> value) => obj.AddValue(WeaponDefaultBulletDamage, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasWeaponDefaultBulletDamage(this IEntity obj) => obj.HasValue(WeaponDefaultBulletDamage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelWeaponDefaultBulletDamage(this IEntity obj) => obj.DelValue(WeaponDefaultBulletDamage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWeaponDefaultBulletDamage(this IEntity obj, Const<int> value) => obj.SetValue(WeaponDefaultBulletDamage, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BulletEntityInstaller GetWeaponBulletPrefab(this IEntity obj) => obj.GetValue<BulletEntityInstaller>(WeaponBulletPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetWeaponBulletPrefab(this IEntity obj, out BulletEntityInstaller value) => obj.TryGetValue(WeaponBulletPrefab, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddWeaponBulletPrefab(this IEntity obj, BulletEntityInstaller value) => obj.AddValue(WeaponBulletPrefab, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasWeaponBulletPrefab(this IEntity obj) => obj.HasValue(WeaponBulletPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelWeaponBulletPrefab(this IEntity obj) => obj.DelValue(WeaponBulletPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWeaponBulletPrefab(this IEntity obj, BulletEntityInstaller value) => obj.SetValue(WeaponBulletPrefab, value);
    }
}
