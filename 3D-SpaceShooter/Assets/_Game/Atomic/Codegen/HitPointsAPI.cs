/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Entities;
using System.Runtime.CompilerServices;
using Atomic.Elements;

namespace Atomic.Entities
{
    public static class HitPointsAPI
    {
        ///Keys
        public const int CurrentHp = 11; // ReactiveInt
        public const int MaxHp = 12; // ReactiveInt
        public const int CanTakeDamage = 13; // AndExpression
        public const int TakeDamageEvent = 14; // BaseEvent<int>
        public const int IsDead = 15; // ReactiveBool


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveInt GetCurrentHp(this IEntity obj) => obj.GetValue<ReactiveInt>(CurrentHp);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCurrentHp(this IEntity obj, out ReactiveInt value) => obj.TryGetValue(CurrentHp, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCurrentHp(this IEntity obj, ReactiveInt value) => obj.AddValue(CurrentHp, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCurrentHp(this IEntity obj) => obj.HasValue(CurrentHp);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCurrentHp(this IEntity obj) => obj.DelValue(CurrentHp);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCurrentHp(this IEntity obj, ReactiveInt value) => obj.SetValue(CurrentHp, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveInt GetMaxHp(this IEntity obj) => obj.GetValue<ReactiveInt>(MaxHp);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMaxHp(this IEntity obj, out ReactiveInt value) => obj.TryGetValue(MaxHp, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddMaxHp(this IEntity obj, ReactiveInt value) => obj.AddValue(MaxHp, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasMaxHp(this IEntity obj) => obj.HasValue(MaxHp);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelMaxHp(this IEntity obj) => obj.DelValue(MaxHp);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMaxHp(this IEntity obj, ReactiveInt value) => obj.SetValue(MaxHp, value);

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
