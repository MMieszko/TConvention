using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Client.Console.Components;

namespace Client.Console.Extensions
{
    public static class AssemblyExtensions
    {
        public static T[] AsArray<T>(this T @this)
        {
            return new[] { @this };
        }

        public static Class[] GetClasses(this Assembly @this)
        {
            return @this.GetTypes().Select(x => (Class)x).ToArray();
        }

        public static Class[] GetClasses(this ICollection<Type> @this)
        {
            return @this.Select(x => (Class)x).ToArray();
        }
    }
}