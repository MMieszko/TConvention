using System;
using Client.Console.Filters.Classes;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Filters.Fields
{
    public interface IFieldFilter : IFilter
    {
        IFieldFilter WithModifier(FieldModifier modifier);
        IFieldFilter WithType<T>();
        IFieldFilter WithAttribute<TAttribute>()
            where TAttribute : Attribute;
    }
}