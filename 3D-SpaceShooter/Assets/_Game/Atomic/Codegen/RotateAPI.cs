/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Entities;
using System.Runtime.CompilerServices;
using Atomic.Elements;
using Elementary;

namespace Atomic.Entities
{
    public static class RotateAPI
    {
        ///Keys
        public const int Rotation = 5; // ReactiveQuaternion
        public const int TiltAmount = 9; // Const<float>
        public const int TiltSmoothness = 10; // Const<float>
        public const int CanRotate = 22; // AndExpression


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveQuaternion GetRotation(this IEntity obj) => obj.GetValue<ReactiveQuaternion>(Rotation);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetRotation(this IEntity obj, out ReactiveQuaternion value) => obj.TryGetValue(Rotation, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddRotation(this IEntity obj, ReactiveQuaternion value) => obj.AddValue(Rotation, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasRotation(this IEntity obj) => obj.HasValue(Rotation);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelRotation(this IEntity obj) => obj.DelValue(Rotation);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetRotation(this IEntity obj, ReactiveQuaternion value) => obj.SetValue(Rotation, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Const<float> GetTiltAmount(this IEntity obj) => obj.GetValue<Const<float>>(TiltAmount);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetTiltAmount(this IEntity obj, out Const<float> value) => obj.TryGetValue(TiltAmount, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddTiltAmount(this IEntity obj, Const<float> value) => obj.AddValue(TiltAmount, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasTiltAmount(this IEntity obj) => obj.HasValue(TiltAmount);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelTiltAmount(this IEntity obj) => obj.DelValue(TiltAmount);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetTiltAmount(this IEntity obj, Const<float> value) => obj.SetValue(TiltAmount, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Const<float> GetTiltSmoothness(this IEntity obj) => obj.GetValue<Const<float>>(TiltSmoothness);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetTiltSmoothness(this IEntity obj, out Const<float> value) => obj.TryGetValue(TiltSmoothness, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddTiltSmoothness(this IEntity obj, Const<float> value) => obj.AddValue(TiltSmoothness, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasTiltSmoothness(this IEntity obj) => obj.HasValue(TiltSmoothness);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelTiltSmoothness(this IEntity obj) => obj.DelValue(TiltSmoothness);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetTiltSmoothness(this IEntity obj, Const<float> value) => obj.SetValue(TiltSmoothness, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AndExpression GetCanRotate(this IEntity obj) => obj.GetValue<AndExpression>(CanRotate);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCanRotate(this IEntity obj, out AndExpression value) => obj.TryGetValue(CanRotate, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCanRotate(this IEntity obj, AndExpression value) => obj.AddValue(CanRotate, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCanRotate(this IEntity obj) => obj.HasValue(CanRotate);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCanRotate(this IEntity obj) => obj.DelValue(CanRotate);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCanRotate(this IEntity obj, AndExpression value) => obj.SetValue(CanRotate, value);
    }
}
