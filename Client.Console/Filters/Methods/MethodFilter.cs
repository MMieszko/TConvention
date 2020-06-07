using System;
using Client.Console.Asserts.Methods;
using Client.Console.Components;
using Client.Console.Extensions;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Filters.Methods
{
    public class MethodFilter : IMethodsFilter
    {
        public Method[] Methods { get; private set; }

        public MethodFilter(Method[] classes)
        {
            Methods = classes;
        }

        public IMethodsFilter WithModifier(MethodModifier modifier)
        {
            this.Methods = this.Methods.FilterByModifier(modifier);

            return this;
        }

        public IMethodsFilter WhichReturns<T>()
        {
            this.Methods = this.Methods.FilterByReturnType<T>();

            return this;
        }

        public IMethodsFilter WithAttribute<TAttribute>()
            where TAttribute : Attribute
        {
            this.Methods = Methods.FilterByAttribute<TAttribute>();

            return this;
        }

        public IMethodsFilter WhichReturnsVoid()
        {
            this.Methods = Methods.FilterByVoidMethods();

            return this;
        }
    }
}