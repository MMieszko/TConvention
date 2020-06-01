using System;
using Client.Console.Asserts.Properties;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Filters.Properties
{
    public interface IPropertyFilter
    {
        IPropertyFilter WithModifier(PropertyModifier modifier);
        IPropertyFilter WithType<T>();
        IPropertyFilter WithAttribute<T>() where T : Attribute;
    }
}