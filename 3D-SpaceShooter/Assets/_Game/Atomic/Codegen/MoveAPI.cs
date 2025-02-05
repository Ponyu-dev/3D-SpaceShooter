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
    public static class MoveAPI
    {
        ///Keys
        public const int MoveSpeed = 1; // ReactiveFloat
        public const int MoveDirection = 2; // ReactiveVector3
        public const int CanMove = 3; // AndExpression
        public const int Position = 4; // ReactiveVector3
        public const int MoveBounds = 6; // Const<Bounds>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveFloat GetMoveSpeed(this IEntity obj) => obj.GetValue<ReactiveFloat>(MoveSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMoveSpeed(this IEntity obj, out ReactiveFloat value) => obj.TryGetValue(MoveSpeed, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddMoveSpeed(this IEntity obj, ReactiveFloat value) => obj.AddValue(MoveSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasMoveSpeed(this IEntity obj) => obj.HasValue(MoveSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelMoveSpeed(this IEntity obj) => obj.DelValue(MoveSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMoveSpeed(this IEntity obj, ReactiveFloat value) => obj.SetValue(MoveSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVector3 GetMoveDirection(this IEntity obj) => obj.GetValue<ReactiveVector3>(MoveDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMoveDirection(this IEntity obj, out ReactiveVector3 value) => obj.TryGetValue(MoveDirection, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddMoveDirection(this IEntity obj, ReactiveVector3 value) => obj.AddValue(MoveDirection, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasMoveDirection(this IEntity obj) => obj.HasValue(MoveDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelMoveDirection(this IEntity obj) => obj.DelValue(MoveDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMoveDirection(this IEntity obj, ReactiveVector3 value) => obj.SetValue(MoveDirection, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AndExpression GetCanMove(this IEntity obj) => obj.GetValue<AndExpression>(CanMove);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCanMove(this IEntity obj, out AndExpression value) => obj.TryGetValue(CanMove, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCanMove(this IEntity obj, AndExpression value) => obj.AddValue(CanMove, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCanMove(this IEntity obj) => obj.HasValue(CanMove);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCanMove(this IEntity obj) => obj.DelValue(CanMove);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCanMove(this IEntity obj, AndExpression value) => obj.SetValue(CanMove, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVector3 GetPosition(this IEntity obj) => obj.GetValue<ReactiveVector3>(Position);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetPosition(this IEntity obj, out ReactiveVector3 value) => obj.TryGetValue(Position, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddPosition(this IEntity obj, ReactiveVector3 value) => obj.AddValue(Position, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasPosition(this IEntity obj) => obj.HasValue(Position);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelPosition(this IEntity obj) => obj.DelValue(Position);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetPosition(this IEntity obj, ReactiveVector3 value) => obj.SetValue(Position, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Const<Bounds> GetMoveBounds(this IEntity obj) => obj.GetValue<Const<Bounds>>(MoveBounds);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMoveBounds(this IEntity obj, out Const<Bounds> value) => obj.TryGetValue(MoveBounds, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddMoveBounds(this IEntity obj, Const<Bounds> value) => obj.AddValue(MoveBounds, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasMoveBounds(this IEntity obj) => obj.HasValue(MoveBounds);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelMoveBounds(this IEntity obj) => obj.DelValue(MoveBounds);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMoveBounds(this IEntity obj, Const<Bounds> value) => obj.SetValue(MoveBounds, value);
    }
}
