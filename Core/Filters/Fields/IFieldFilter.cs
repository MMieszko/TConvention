using System;
using Core.Components;
using Core.Modifiers;

namespace Core.Filters.Fields
{
    public interface IFieldFilter : IFilter<Field>
    {
        //Field[] Components { get; }
        IFieldFilter WithModifier(FieldModifier modifier);
        IFieldFilter WithAttribute<TAttribute>() where TAttribute : Attribute;
        IFieldFilter WithType<T>();
    }
}