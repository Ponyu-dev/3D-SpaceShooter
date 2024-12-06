/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Contexts;
using System.Runtime.CompilerServices;
using Atomic.Elements;
using UnityEngine.InputSystem;
using Elementary;

namespace Atomic.Contexts
{
	public static class GameAPI
	{
		///Keys
		public const int WorldTransform = 1; // Const<Transform>
		public const int PlayerInput = 2; // Const<PlayerInput>
		public const int MainCamera = 3; // Const<Camera>
		public const int IsTouching = 4; // ReactiveBool
		public const int DeltaMove = 5; // ReactiveVector3
		public const int PlayerBounds = 9; // ReactiveVariable<Bounds>
		public const int TriggerSensor = 12; // Const<TriggerSensor>
		public const int CanGamePlay = 14; // AndExpression
		public const int IsGamePlay = 15; // ReactiveBool


		///Extensions
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<Transform> GetWorldTransform(this IContext obj) => obj.ResolveValue<Const<Transform>>(WorldTransform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetWorldTransform(this IContext obj, out Const<Transform> value) => obj.TryResolveValue(WorldTransform, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddWorldTransform(this IContext obj, Const<Transform> value) => obj.AddValue(WorldTransform, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelWorldTransform(this IContext obj) => obj.DelValue(WorldTransform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWorldTransform(this IContext obj, Const<Transform> value) => obj.SetValue(WorldTransform, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasWorldTransform(this IContext obj) => obj.HasValue(WorldTransform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<PlayerInput> GetPlayerInput(this IContext obj) => obj.ResolveValue<Const<PlayerInput>>(PlayerInput);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPlayerInput(this IContext obj, out Const<PlayerInput> value) => obj.TryResolveValue(PlayerInput, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPlayerInput(this IContext obj, Const<PlayerInput> value) => obj.AddValue(PlayerInput, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPlayerInput(this IContext obj) => obj.DelValue(PlayerInput);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPlayerInput(this IContext obj, Const<PlayerInput> value) => obj.SetValue(PlayerInput, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPlayerInput(this IContext obj) => obj.HasValue(PlayerInput);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<Camera> GetMainCamera(this IContext obj) => obj.ResolveValue<Const<Camera>>(MainCamera);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMainCamera(this IContext obj, out Const<Camera> value) => obj.TryResolveValue(MainCamera, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMainCamera(this IContext obj, Const<Camera> value) => obj.AddValue(MainCamera, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMainCamera(this IContext obj) => obj.DelValue(MainCamera);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMainCamera(this IContext obj, Const<Camera> value) => obj.SetValue(MainCamera, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMainCamera(this IContext obj) => obj.HasValue(MainCamera);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveBool GetIsTouching(this IContext obj) => obj.ResolveValue<ReactiveBool>(IsTouching);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetIsTouching(this IContext obj, out ReactiveBool value) => obj.TryResolveValue(IsTouching, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddIsTouching(this IContext obj, ReactiveBool value) => obj.AddValue(IsTouching, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelIsTouching(this IContext obj) => obj.DelValue(IsTouching);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetIsTouching(this IContext obj, ReactiveBool value) => obj.SetValue(IsTouching, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasIsTouching(this IContext obj) => obj.HasValue(IsTouching);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveVector3 GetDeltaMove(this IContext obj) => obj.ResolveValue<ReactiveVector3>(DeltaMove);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDeltaMove(this IContext obj, out ReactiveVector3 value) => obj.TryResolveValue(DeltaMove, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDeltaMove(this IContext obj, ReactiveVector3 value) => obj.AddValue(DeltaMove, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDeltaMove(this IContext obj) => obj.DelValue(DeltaMove);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDeltaMove(this IContext obj, ReactiveVector3 value) => obj.SetValue(DeltaMove, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDeltaMove(this IContext obj) => obj.HasValue(DeltaMove);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveVariable<Bounds> GetPlayerBounds(this IContext obj) => obj.ResolveValue<ReactiveVariable<Bounds>>(PlayerBounds);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPlayerBounds(this IContext obj, out ReactiveVariable<Bounds> value) => obj.TryResolveValue(PlayerBounds, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPlayerBounds(this IContext obj, ReactiveVariable<Bounds> value) => obj.AddValue(PlayerBounds, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPlayerBounds(this IContext obj) => obj.DelValue(PlayerBounds);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPlayerBounds(this IContext obj, ReactiveVariable<Bounds> value) => obj.SetValue(PlayerBounds, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPlayerBounds(this IContext obj) => obj.HasValue(PlayerBounds);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<TriggerSensor> GetTriggerSensor(this IContext obj) => obj.ResolveValue<Const<TriggerSensor>>(TriggerSensor);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTriggerSensor(this IContext obj, out Const<TriggerSensor> value) => obj.TryResolveValue(TriggerSensor, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTriggerSensor(this IContext obj, Const<TriggerSensor> value) => obj.AddValue(TriggerSensor, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTriggerSensor(this IContext obj) => obj.DelValue(TriggerSensor);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTriggerSensor(this IContext obj, Const<TriggerSensor> value) => obj.SetValue(TriggerSensor, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTriggerSensor(this IContext obj) => obj.HasValue(TriggerSensor);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static AndExpression GetCanGamePlay(this IContext obj) => obj.ResolveValue<AndExpression>(CanGamePlay);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCanGamePlay(this IContext obj, out AndExpression value) => obj.TryResolveValue(CanGamePlay, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCanGamePlay(this IContext obj, AndExpression value) => obj.AddValue(CanGamePlay, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCanGamePlay(this IContext obj) => obj.DelValue(CanGamePlay);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCanGamePlay(this IContext obj, AndExpression value) => obj.SetValue(CanGamePlay, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCanGamePlay(this IContext obj) => obj.HasValue(CanGamePlay);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveBool GetIsGamePlay(this IContext obj) => obj.ResolveValue<ReactiveBool>(IsGamePlay);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetIsGamePlay(this IContext obj, out ReactiveBool value) => obj.TryResolveValue(IsGamePlay, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddIsGamePlay(this IContext obj, ReactiveBool value) => obj.AddValue(IsGamePlay, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelIsGamePlay(this IContext obj) => obj.DelValue(IsGamePlay);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetIsGamePlay(this IContext obj, ReactiveBool value) => obj.SetValue(IsGamePlay, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasIsGamePlay(this IContext obj) => obj.HasValue(IsGamePlay);
    }
}
