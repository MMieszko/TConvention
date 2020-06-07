using System;
using System.Linq;
using Core.Components;
using Core.Modifiers;

namespace Core.Filters.Methods
{
    public class MethodFilter : Filter<Method, MethodModifier>, IMethodsFilter
    {
        public MethodFilter(Method[] methods)
            :base(methods)
        {

        }

        public IMethodsFilter WithModifier(MethodModifier modifier)
        {
            return new MethodFilter(this.Components.Where(x => x.Is(modifier)).ToArray());
        }

        public IMethodsFilter WhichReturns<T>()
        {
            return new MethodFilter(this.Components.Where(x => x.ReturnType == typeof(T)).ToArray());
        }

        public IMethodsFilter WithAttribute<TAttribute>()
            where TAttribute : Attribute
        {
            return (IMethodsFilter) base.FilterAttributes<TAttribute>();
        }

        public IMethodsFilter WhichReturnsVoid()
        {
            return new MethodFilter(this.Components.Where(x => x.IsVoid).ToArray());
        }

        public IMethodsFilter Public()
        {
            return this.WithModifier(MethodModifier.Public);
        }

        public IMethodsFilter Internal()
        {
            return this.WithModifier(MethodModifier.Internal);
        }

        public IMethodsFilter Protected()
        {
            return this.WithModifier(MethodModifier.Protected);
        }

        public IMethodsFilter Private()
        {
            return this.WithModifier(MethodModifier.Private);
        }
    }
}