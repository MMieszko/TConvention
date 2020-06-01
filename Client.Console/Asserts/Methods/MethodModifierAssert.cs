using System.Collections.Generic;
using Client.Console.Components;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Asserts.Methods
{
    public class MethodModifierAssert : MethodAssert, IMethodModifierAssert
    {
        public MethodModifier Modifier { get; }

        public MethodModifierAssert(MethodModifier modifier, Method[] methods)
            : base(methods)
        {
            this.Modifier = modifier;
        }

        public IMethodModifierAssert HaveMaximumCount(int count)
        {
            if (Components.Length >= count)
            {
                //TODO:
            }

            return this;
        }

        public IMethodModifierAssert HaveMinimumCount(int count)
        {
            if (Components.Length <= count)
            {
                //TODO:
            }

            return this;
        }
    }
}