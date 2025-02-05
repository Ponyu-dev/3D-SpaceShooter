/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Contexts;
using System.Runtime.CompilerServices;
using Atomic.Elements;
using UnityEngine.Jobs;
using _Game.Gameplay.Asteroids.Scripts.Data;

namespace Atomic.Contexts
{
	public static class AsteroidsAPI
	{
		///Keys
		public const int ReactiveAsteroidsProperties = 8; // ReactiveVariable<AsteroidsProperties>
		public const int AsteroidsContainer = 10; // Const<Transform>
		public const int AsteroidsBounds = 11; // Const<Bounds>
		public const int SpawnAsteroidData = 13; // Const<SpawnAsteroidData>


		///Extensions
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveVariable<AsteroidsProperties> GetReactiveAsteroidsProperties(this IContext obj) => obj.ResolveValue<ReactiveVariable<AsteroidsProperties>>(ReactiveAsteroidsProperties);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetReactiveAsteroidsProperties(this IContext obj, out ReactiveVariable<AsteroidsProperties> value) => obj.TryResolveValue(ReactiveAsteroidsProperties, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddReactiveAsteroidsProperties(this IContext obj, ReactiveVariable<AsteroidsProperties> value) => obj.AddValue(ReactiveAsteroidsProperties, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelReactiveAsteroidsProperties(this IContext obj) => obj.DelValue(ReactiveAsteroidsProperties);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetReactiveAsteroidsProperties(this IContext obj, ReactiveVariable<AsteroidsProperties> value) => obj.SetValue(ReactiveAsteroidsProperties, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasReactiveAsteroidsProperties(this IContext obj) => obj.HasValue(ReactiveAsteroidsProperties);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<Transform> GetAsteroidsContainer(this IContext obj) => obj.ResolveValue<Const<Transform>>(AsteroidsContainer);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAsteroidsContainer(this IContext obj, out Const<Transform> value) => obj.TryResolveValue(AsteroidsContainer, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAsteroidsContainer(this IContext obj, Const<Transform> value) => obj.AddValue(AsteroidsContainer, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAsteroidsContainer(this IContext obj) => obj.DelValue(AsteroidsContainer);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAsteroidsContainer(this IContext obj, Const<Transform> value) => obj.SetValue(AsteroidsContainer, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAsteroidsContainer(this IContext obj) => obj.HasValue(AsteroidsContainer);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<Bounds> GetAsteroidsBounds(this IContext obj) => obj.ResolveValue<Const<Bounds>>(AsteroidsBounds);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAsteroidsBounds(this IContext obj, out Const<Bounds> value) => obj.TryResolveValue(AsteroidsBounds, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAsteroidsBounds(this IContext obj, Const<Bounds> value) => obj.AddValue(AsteroidsBounds, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAsteroidsBounds(this IContext obj) => obj.DelValue(AsteroidsBounds);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAsteroidsBounds(this IContext obj, Const<Bounds> value) => obj.SetValue(AsteroidsBounds, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAsteroidsBounds(this IContext obj) => obj.HasValue(AsteroidsBounds);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<SpawnAsteroidData> GetSpawnAsteroidData(this IContext obj) => obj.ResolveValue<Const<SpawnAsteroidData>>(SpawnAsteroidData);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetSpawnAsteroidData(this IContext obj, out Const<SpawnAsteroidData> value) => obj.TryResolveValue(SpawnAsteroidData, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddSpawnAsteroidData(this IContext obj, Const<SpawnAsteroidData> value) => obj.AddValue(SpawnAsteroidData, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelSpawnAsteroidData(this IContext obj) => obj.DelValue(SpawnAsteroidData);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetSpawnAsteroidData(this IContext obj, Const<SpawnAsteroidData> value) => obj.SetValue(SpawnAsteroidData, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasSpawnAsteroidData(this IContext obj) => obj.HasValue(SpawnAsteroidData);
    }
}
