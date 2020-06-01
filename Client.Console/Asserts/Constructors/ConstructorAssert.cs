using System.Collections.Generic;
using Client.Console.Asserts.Methods;
using Client.Console.Components;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Asserts.Constructors
{
    public class ConstructorAssert : Assert<Constructor>, IConstructorAssert
    {
        public ConstructorAssert(Constructor[] components)
            : base(components)
        {
        }

        public IConstructorAssert HasMaximum(int count)
        {
            throw new System.NotImplementedException();
        }

        public IConstructorAssert HasMaximum(ConstructorModifier type, int count)
        {
            throw new System.NotImplementedException();
        }

        public IConstructorAssert HasMinimum(ConstructorModifier type, int count)
        {
            throw new System.NotImplementedException();
        }

        public IMethodAssert HasMaximumArgumentsCount(int count)
        {
            throw new System.NotImplementedException();
        }

        public IMethodAssert HasMinimumArgumentsCount(int count)
        {
            throw new System.NotImplementedException();
        }
    }
}