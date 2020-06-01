using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Client.Console.Components;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Extensions
{
    public static class PropertyCollectionExtensions
    {
        public static Property[] FilterByType<T>(this ICollection<Property> @this)
        {
            return @this.Where(x => x.Type == typeof(T)).ToArray();
        }

        /// <summary>
        /// Returns flatten methods belongs only to instance which contains given attribute
        /// </summary>
        public static Property[] FilterByAttribute<TAttribute>(this ICollection<Property> @this)
            where TAttribute : Attribute
        {
            return @this.Where(x => x.HasAttribute<TAttribute>()).ToArray();
        }

        /// <summary>
        /// Returns flatten methods having given modifier belong to only to instance without base methods
        /// </summary>
        public static Property[] GetProperties(this ICollection<Type> @this, PropertyModifier modifier)
        {
            return @this.GetProperties().FilterByModifier(modifier).ToArray();
        }

        /// <summary>
        /// Returns flatten methods belong to only to instance without base methods
        /// </summary>
        public static Property[] GetProperties(this ICollection<Type> @this)
        {
            return @this.SelectMany(x => x.GetDeclaringProperties()).Select(x => x).ToArray();
        }

        /// <summary>
        /// Return method which belong only to instance without base methods
        /// </summary>
        public static Property[] GetDeclaringProperties(this Type @this)
        {
            return @this.GetProperties(BindingFlags.DeclaredOnly).Select(x => (Property)x).ToArray();
        }

        /// <summary>
        /// Returns methods which are filtered by given modifier using <see cref="Method.HasModifier"/>
        /// </summary>
        /// <param name="this"></param>
        /// <param name="modifier"></param>
        /// <returns></returns>
        public static Property[] FilterByModifier(this ICollection<Property> @this, PropertyModifier modifier)
        {
            return @this.Where(x => x.HasModifier(modifier)).ToArray();
        }
    }
}