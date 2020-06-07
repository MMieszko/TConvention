using System;
using Core.Components;
using Core.Modifiers;

namespace Core.Filters.Methods
{
    public interface IMethodsFilter : IFilter<Method>
    {
        IMethodsFilter WithModifier(MethodModifier modifier);
        IMethodsFilter WhichReturns<T>();
        IMethodsFilter WithAttribute<TAttribute>() where TAttribute : Attribute;
        IMethodsFilter WhichReturnsVoid();
        IMethodsFilter Public();
        IMethodsFilter Internal();
        IMethodsFilter Protected();
        IMethodsFilter Private();
    }
}