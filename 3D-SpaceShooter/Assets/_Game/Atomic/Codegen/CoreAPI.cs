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
    public static class CoreAPI
    {
        ///Keys
        public const int Transform = 7; // Const<Transform>
        public const int MainCamera = 8; // Const<Camera>
        public const int DespawnEvent = 17; // BaseEvent<IEntity>
        public const int CollisionSensor = 18; // Const<CollisionSensor>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Const<Transform> GetTransform(this IEntity obj) => obj.GetValue<Const<Transform>>(Transform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetTransform(this IEntity obj, out Const<Transform> value) => obj.TryGetValue(Transform, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddTransform(this IEntity obj, Const<Transform> value) => obj.AddValue(Transform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasTransform(this IEntity obj) => obj.HasValue(Transform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelTransform(this IEntity obj) => obj.DelValue(Transform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetTransform(this IEntity obj, Const<Transform> value) => obj.SetValue(Transform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Const<Camera> GetMainCamera(this IEntity obj) => obj.GetValue<Const<Camera>>(MainCamera);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMainCamera(this IEntity obj, out Const<Camera> value) => obj.TryGetValue(MainCamera, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddMainCamera(this IEntity obj, Const<Camera> value) => obj.AddValue(MainCamera, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasMainCamera(this IEntity obj) => obj.HasValue(MainCamera);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelMainCamera(this IEntity obj) => obj.DelValue(MainCamera);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMainCamera(this IEntity obj, Const<Camera> value) => obj.SetValue(MainCamera, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BaseEvent<IEntity> GetDespawnEvent(this IEntity obj) => obj.GetValue<BaseEvent<IEntity>>(DespawnEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetDespawnEvent(this IEntity obj, out BaseEvent<IEntity> value) => obj.TryGetValue(DespawnEvent, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddDespawnEvent(this IEntity obj, BaseEvent<IEntity> value) => obj.AddValue(DespawnEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasDespawnEvent(this IEntity obj) => obj.HasValue(DespawnEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelDespawnEvent(this IEntity obj) => obj.DelValue(DespawnEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetDespawnEvent(this IEntity obj, BaseEvent<IEntity> value) => obj.SetValue(DespawnEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Const<CollisionSensor> GetCollisionSensor(this IEntity obj) => obj.GetValue<Const<CollisionSensor>>(CollisionSensor);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCollisionSensor(this IEntity obj, out Const<CollisionSensor> value) => obj.TryGetValue(CollisionSensor, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCollisionSensor(this IEntity obj, Const<CollisionSensor> value) => obj.AddValue(CollisionSensor, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCollisionSensor(this IEntity obj) => obj.HasValue(CollisionSensor);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCollisionSensor(this IEntity obj) => obj.DelValue(CollisionSensor);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCollisionSensor(this IEntity obj, Const<CollisionSensor> value) => obj.SetValue(CollisionSensor, value);
    }
}
