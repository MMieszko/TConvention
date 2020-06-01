using System;
using System.Collections.Generic;
using System.Linq;
using Client.Console.Components;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Extensions
{
    public static class FieldCollectionExtensions
    {
        /// <summary>
        /// Returns flatten methods belong to only to instance without base methods
        /// </summary>
        public static Field[] GetFields(this ICollection<Type> @this)
        {
            return @this.SelectMany(x => x.GetDeclaringFields()).ToArray();
        }
        public static Field[] FilterByAttribute<TAttribute>(this ICollection<Field> @this)
            where TAttribute : Attribute
        {
            return @this.Where(x => x.HasAttribute<TAttribute>()).ToArray();
        }

        /// <summary>
        /// Return fields which belong only to instance without base fields
        /// </summary>
        public static ICollection<Field> GetDeclaringFields(this Type @this)
        {
            return @this.GetFields().Where(x => x.DeclaringType == @this).Select(x => (Field)x).ToList();
        }

        /// <summary>
        /// Returns flatten fields belongs only to instance which return given type
        /// </summary>
        public static Field[] FilterByType<T>(this ICollection<Field> @this)
        {
            return @this.Where(x => x.GetType() == typeof(T)).ToArray();
        }

        /// <summary>
        /// Returns flatten fields having given modifier belong to only to instance without base fields
        /// </summary>
        public static Field[] FilterByModifier(this ICollection<Field> @this, FieldModifier modifier)
        {
            return @this.GetWithModifier(modifier).ToArray();
        }

        /// <summary>
        /// Returns methods which are filtered by given modifier using <see cref="Method.HasModifier"/>
        /// </summary>
        /// <param name="this"></param>
        /// <param name="modifier"></param>
        /// <returns></returns>
        public static Field[] GetWithModifier(this ICollection<Field> @this, FieldModifier modifier)
        {
            return @this.Where(x => x.HasModifier(modifier)).ToArray();
        }
    }
}