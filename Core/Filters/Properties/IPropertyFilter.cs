using System;
using Core.Components;
using Core.Modifiers;

namespace Core.Filters.Properties
{
    public interface IPropertyFilter : IFilter<Property>
    {
        IPropertyFilter Static();
        IPropertyFilter Abstract();
        IPropertyFilter PublicWithProtectedSet();
        IPropertyFilter PublicWithPrivateSet();
        IPropertyFilter Public();
        IPropertyFilter Private();
        IPropertyFilter Protected();
        IPropertyFilter PublicReadonly();
        IPropertyFilter ProtectedReadonly();
        IPropertyFilter PrivateReadonly();
        IPropertyFilter WithType<T>();
        IPropertyFilter WithAttribute<T>() where T : Attribute;
        IPropertyFilter WithModifier(PropertyModifier modifier);
    }
}