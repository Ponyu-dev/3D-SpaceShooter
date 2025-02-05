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
    public static class AsteroidAPI
    {
        ///Keys
        public const int AsteroidIndex = 16; // Const<int>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Const<int> GetAsteroidIndex(this IEntity obj) => obj.GetValue<Const<int>>(AsteroidIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetAsteroidIndex(this IEntity obj, out Const<int> value) => obj.TryGetValue(AsteroidIndex, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddAsteroidIndex(this IEntity obj, Const<int> value) => obj.AddValue(AsteroidIndex, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasAsteroidIndex(this IEntity obj) => obj.HasValue(AsteroidIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelAsteroidIndex(this IEntity obj) => obj.DelValue(AsteroidIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetAsteroidIndex(this IEntity obj, Const<int> value) => obj.SetValue(AsteroidIndex, value);
    }
}
