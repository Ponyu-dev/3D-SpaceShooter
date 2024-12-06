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
    public static class HitPointsAPI
    {
        ///Keys
        public const int HitPoint = 11; // IntVariableLimited
        public const int CanTakeDamage = 13; // AndExpression
        public const int TakeDamageEvent = 14; // BaseEvent<int>
        public const int IsDead = 15; // ReactiveBool


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IntVariableLimited GetHitPoint(this IEntity obj) => obj.GetValue<IntVariableLimited>(HitPoint);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetHitPoint(this IEntity obj, out IntVariableLimited value) => obj.TryGetValue(HitPoint, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddHitPoint(this IEntity obj, IntVariableLimited value) => obj.AddValue(HitPoint, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasHitPoint(this IEntity obj) => obj.HasValue(HitPoint);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelHitPoint(this IEntity obj) => obj.DelValue(HitPoint);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetHitPoint(this IEntity obj, IntVariableLimited value) => obj.SetValue(HitPoint, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AndExpression GetCanTakeDamage(this IEntity obj) => obj.GetValue<AndExpression>(CanTakeDamage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCanTakeDamage(this IEntity obj, out AndExpression value) => obj.TryGetValue(CanTakeDamage, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCanTakeDamage(this IEntity obj, AndExpression value) => obj.AddValue(CanTakeDamage, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCanTakeDamage(this IEntity obj) => obj.HasValue(CanTakeDamage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCanTakeDamage(this IEntity obj) => obj.DelValue(CanTakeDamage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCanTakeDamage(this IEntity obj, AndExpression value) => obj.SetValue(CanTakeDamage, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BaseEvent<int> GetTakeDamageEvent(this IEntity obj) => obj.GetValue<BaseEvent<int>>(TakeDamageEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetTakeDamageEvent(this IEntity obj, out BaseEvent<int> value) => obj.TryGetValue(TakeDamageEvent, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddTakeDamageEvent(this IEntity obj, BaseEvent<int> value) => obj.AddValue(TakeDamageEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasTakeDamageEvent(this IEntity obj) => obj.HasValue(TakeDamageEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelTakeDamageEvent(this IEntity obj) => obj.DelValue(TakeDamageEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetTakeDamageEvent(this IEntity obj, BaseEvent<int> value) => obj.SetValue(TakeDamageEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveBool GetIsDead(this IEntity obj) => obj.GetValue<ReactiveBool>(IsDead);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetIsDead(this IEntity obj, out ReactiveBool value) => obj.TryGetValue(IsDead, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddIsDead(this IEntity obj, ReactiveBool value) => obj.AddValue(IsDead, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasIsDead(this IEntity obj) => obj.HasValue(IsDead);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelIsDead(this IEntity obj) => obj.DelValue(IsDead);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetIsDead(this IEntity obj, ReactiveBool value) => obj.SetValue(IsDead, value);
    }
}
