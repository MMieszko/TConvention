using System;
using Client.Console.Components;
using Client.Console.Filters.Classes;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Filters.Methods
{
    public interface IMethodsFilter : IFilter
    {
        Method[] Methods { get; }
        IMethodsFilter WithModifier(MethodModifier modifier);
        IMethodsFilter WhichReturns<T>();
        IMethodsFilter WithAttribute<TAttribute>() where TAttribute : Attribute;
        IMethodsFilter WhichReturnsVoid();
    }
}