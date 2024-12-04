/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Contexts;
using System.Runtime.CompilerServices;
using Atomic.Elements;
using Atomic.Entities;

namespace Atomic.Contexts
{
	public static class PlayerAPI
	{
		///Keys
		public const int PlayerEntity = 6; // Const<IEntity>
		public const int PlayerTransform = 7; // Const<Transform>
		public const int PlayerBounds = 9; // Const<Bounds>


		///Extensions
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<IEntity> GetPlayerEntity(this IContext obj) => obj.ResolveValue<Const<IEntity>>(PlayerEntity);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPlayerEntity(this IContext obj, out Const<IEntity> value) => obj.TryResolveValue(PlayerEntity, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPlayerEntity(this IContext obj, Const<IEntity> value) => obj.AddValue(PlayerEntity, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPlayerEntity(this IContext obj) => obj.DelValue(PlayerEntity);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPlayerEntity(this IContext obj, Const<IEntity> value) => obj.SetValue(PlayerEntity, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPlayerEntity(this IContext obj) => obj.HasValue(PlayerEntity);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<Transform> GetPlayerTransform(this IContext obj) => obj.ResolveValue<Const<Transform>>(PlayerTransform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPlayerTransform(this IContext obj, out Const<Transform> value) => obj.TryResolveValue(PlayerTransform, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPlayerTransform(this IContext obj, Const<Transform> value) => obj.AddValue(PlayerTransform, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPlayerTransform(this IContext obj) => obj.DelValue(PlayerTransform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPlayerTransform(this IContext obj, Const<Transform> value) => obj.SetValue(PlayerTransform, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPlayerTransform(this IContext obj) => obj.HasValue(PlayerTransform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<Bounds> GetPlayerBounds(this IContext obj) => obj.ResolveValue<Const<Bounds>>(PlayerBounds);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPlayerBounds(this IContext obj, out Const<Bounds> value) => obj.TryResolveValue(PlayerBounds, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPlayerBounds(this IContext obj, Const<Bounds> value) => obj.AddValue(PlayerBounds, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPlayerBounds(this IContext obj) => obj.DelValue(PlayerBounds);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPlayerBounds(this IContext obj, Const<Bounds> value) => obj.SetValue(PlayerBounds, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPlayerBounds(this IContext obj) => obj.HasValue(PlayerBounds);
    }
}
