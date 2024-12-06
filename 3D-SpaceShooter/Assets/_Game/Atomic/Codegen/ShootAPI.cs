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
    public static class ShootAPI
    {
        ///Keys
        public const int PeriodShoot = 12; // Cycle
        public const int CanShoot = 20; // AndExpression
        public const int ActionShoot = 21; // BaseEvent


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Cycle GetPeriodShoot(this IEntity obj) => obj.GetValue<Cycle>(PeriodShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetPeriodShoot(this IEntity obj, out Cycle value) => obj.TryGetValue(PeriodShoot, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddPeriodShoot(this IEntity obj, Cycle value) => obj.AddValue(PeriodShoot, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasPeriodShoot(this IEntity obj) => obj.HasValue(PeriodShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelPeriodShoot(this IEntity obj) => obj.DelValue(PeriodShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetPeriodShoot(this IEntity obj, Cycle value) => obj.SetValue(PeriodShoot, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AndExpression GetCanShoot(this IEntity obj) => obj.GetValue<AndExpression>(CanShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCanShoot(this IEntity obj, out AndExpression value) => obj.TryGetValue(CanShoot, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCanShoot(this IEntity obj, AndExpression value) => obj.AddValue(CanShoot, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCanShoot(this IEntity obj) => obj.HasValue(CanShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCanShoot(this IEntity obj) => obj.DelValue(CanShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCanShoot(this IEntity obj, AndExpression value) => obj.SetValue(CanShoot, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BaseEvent GetActionShoot(this IEntity obj) => obj.GetValue<BaseEvent>(ActionShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetActionShoot(this IEntity obj, out BaseEvent value) => obj.TryGetValue(ActionShoot, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddActionShoot(this IEntity obj, BaseEvent value) => obj.AddValue(ActionShoot, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasActionShoot(this IEntity obj) => obj.HasValue(ActionShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelActionShoot(this IEntity obj) => obj.DelValue(ActionShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetActionShoot(this IEntity obj, BaseEvent value) => obj.SetValue(ActionShoot, value);
    }
}
