using System;
using Client.Console.Asserts.Classes;
using Client.Console.Components;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Filters.Classes
{
    public class ClassFilter : IClassFilter
    {
        protected Class[] Classes;

        public ClassFilter(Class[] classes)
        {
            this.Classes = classes;
        }


        public IConcreteClassAssert<TClass> Concrete<TClass>() where TClass : class
        {
            throw new NotImplementedException();
        }

        public IClassFilter Derives<TClass>() where TClass : class
        {
            throw new NotImplementedException();
        }

        public IClassFilter Implements<TInterface>() where TInterface : class
        {
            throw new NotImplementedException();
        }

        public IClassFilter WithModifier(ClassModifier modifier)
        {
            return this;
        }

        public IClassFilter WithAttribute<TAttribute>(ClassModifier modifier) where TAttribute : Attribute
        {
            throw new NotImplementedException();
        }

        public IClassFilter WithEnds(string suffix)
        {
            return this;
        }

        public IClassFilter Ignore<T>()
        {
            throw new NotImplementedException();
        }

        public IClassFilter Ignore<T1, T2>()
        {
            throw new NotImplementedException();
        }

        public IClassFilter Ignore<T1, T2, T3>()
        {
            throw new NotImplementedException();
        }

        public IClassFilter Ignore<T1, T2, T3, T4, T5>()
        {
            throw new NotImplementedException();
        }

        public IClassFilter Ignore<T1, T2, T3, T4, T5, T6>()
        {
            throw new NotImplementedException();
        }

        public IClassFilter Ignore<T1, T2, T3, T4, T5, T6, T7>()
        {
            throw new NotImplementedException();
        }

        public IClassFilter Ignore<T1, T2, T3, T4, T5, T6, T7, T8>()
        {
            throw new NotImplementedException();
        }

        public IClassFilter Ignore<T1, T2, T3, T4, T5, T6, T7, T8, T9>()
        {
            throw new NotImplementedException();
        }

        public IClassFilter Ignore<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
        {
            throw new NotImplementedException();
        }
    }
}