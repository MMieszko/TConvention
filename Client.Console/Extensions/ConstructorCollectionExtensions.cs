using System;
using System.Collections.Generic;
using System.Linq;
using Client.Console.Components;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Extensions
{
    public static class ConstructorCollectionExtensions
    {
        public static Constructor[] GetConstructors(this ICollection<Type> @this)
        {
            return @this.SelectMany(x => x.GetConstructor()).ToArray();
        }

        public static Constructor[] FilterByModifier(this ICollection<Constructor> @this, ConstructorModifier modifier)
        {
            return @this.Where(x => x.HasModifier(modifier)).ToArray();
        }

        public static ICollection<Constructor> GetConstructor(this Type @this)
        {
            return @this.GetConstructors().Select(x => (Constructor)x).ToList();
        }
    }
}