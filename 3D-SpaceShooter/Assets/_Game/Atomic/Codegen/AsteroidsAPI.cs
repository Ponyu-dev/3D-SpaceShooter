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
    }
}
