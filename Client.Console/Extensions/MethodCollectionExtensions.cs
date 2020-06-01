using System;
using System.Collections.Generic;
using System.Linq;
using Client.Console.Components;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Extensions
{
    public static class MethodCollectionExtensions
    {
        public static Method[] FilterByVoidMethods(this ICollection<Method> @this)
        {
            return @this.Where(x => x.IsVoid).ToArray();
        }

        /// <summary>
        /// Returns flatten methods belongs only to instance which contains given attribute
        /// </summary>
        public static Method[] FilterByAttribute<TAttribute>(this ICollection<Method> @this)
            where TAttribute : Attribute
        {
            return @this.Where(x => x.HasAttribute<TAttribute>()).ToArray();
        }

        /// <summary>
        /// Returns flatten methods belongs only to instance which return given type
        /// </summary>
        public static Method[] FilterByReturnType<TResult>(this ICollection<Method> @this)
        {
            return @this.Where(x => x.ReturnType == typeof(TResult)).ToArray();
        }

        /// <summary>
        /// Returns flatten methods having given modifier belong to only to instance without base methods
        /// </summary>
        public static Method[] GetMethods(this ICollection<Type> @this, MethodModifier modifier)
        {
            return @this.GetMethods().FilterByModifier(modifier).ToArray();
        }

        /// <summary>
        /// Returns flatten methods belong to only to instance without base methods
        /// </summary>
        public static Method[] GetMethods(this ICollection<Type> @this)
        {
            return @this.SelectMany(x => x.GetDeclaringMethods()).ToArray();
        }

        /// <summary>
        /// Return method which belong only to instance without base methods
        /// </summary>
        public static Method[] GetDeclaringMethods(this Type @this)
        {
            return @this.GetMethods().Where(x => x.DeclaringType == @this).Select(x => (Method)x).ToArray();
        }

        /// <summary>
        /// Returns methods which are filtered by given modifier using <see cref="Method.HasModifier"/>
        /// </summary>
        /// <param name="this"></param>
        /// <param name="modifier"></param>
        /// <returns></returns>
        public static Method[] FilterByModifier(this ICollection<Method> @this, MethodModifier modifier)
        {
            return @this.Where(x => x.HasModifier(modifier)).ToArray();
        }
    }
}