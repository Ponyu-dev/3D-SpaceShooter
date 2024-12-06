/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Entities;

namespace Atomic.Entities
{
    public static class TagAPI
    {
        ///Keys
        public const int Player = 1;
        public const int Asteroid = 2;
        public const int Bullet = 3;


        ///Extensions
        public static bool HasPlayerTag(this IEntity obj) => obj.HasTag(Player);
        public static bool NotPlayerTag(this IEntity obj) => !obj.HasTag(Player);
        public static bool AddPlayerTag(this IEntity obj) => obj.AddTag(Player);
        public static bool DelPlayerTag(this IEntity obj) => obj.DelTag(Player);

        public static bool HasAsteroidTag(this IEntity obj) => obj.HasTag(Asteroid);
        public static bool NotAsteroidTag(this IEntity obj) => !obj.HasTag(Asteroid);
        public static bool AddAsteroidTag(this IEntity obj) => obj.AddTag(Asteroid);
        public static bool DelAsteroidTag(this IEntity obj) => obj.DelTag(Asteroid);

        public static bool HasBulletTag(this IEntity obj) => obj.HasTag(Bullet);
        public static bool NotBulletTag(this IEntity obj) => !obj.HasTag(Bullet);
        public static bool AddBulletTag(this IEntity obj) => obj.AddTag(Bullet);
        public static bool DelBulletTag(this IEntity obj) => obj.DelTag(Bullet);
    }
}
