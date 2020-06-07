using System;
using System.Linq;
using System.Threading.Tasks;
using Core.Components;
using Core.Modifiers;

namespace Core.Filters.Methods
{
    public class MethodFilter : Filter<Method>, IMethodsFilter
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

        public IMethodsFilter WhichAnyReturnType()
        {
            return new MethodFilter(this.Components.Where(x => x.ReturnAnything()).ToArray());
        }

        public IMethodsFilter WithAttribute<TAttribute>()
            where TAttribute : Attribute
        {
            return new MethodFilter(Components.Where(x => x.HasAttribute<TAttribute>()).ToArray());
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