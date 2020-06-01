using System;
using System.Collections.Generic;
using Client.Console.Asserts.Constructors;
using Client.Console.Components;
using Client.Console.Extensions;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Filters.Constructors
{
    public class ConstructorFilter : IConstructorFilter
    {
        protected readonly Constructor[] Constructors;

        public ConstructorFilter(Constructor[] constructors)
        {
            Constructors = constructors;
        }

        public IConstructorFilter All(Action<IConstructorAssert> setup)
        {
            setup.Invoke(new ConstructorAssert(Constructors));

            return this;
        }

        public IConstructorFilter WithModifier(ConstructorModifier modifier, Action<IConstructorAssert> setup)
        {
            setup.Invoke(new ConstructorAssert(Constructors.FilterByModifier(modifier)));

            return this;
        }

        public IConstructorFilter WithModifier(ConstructorModifier modifier)
        {
            throw new NotImplementedException();
        }
    }
}