using System;
using System.Collections.Generic;
using System.Linq;
using Client.Console.Components;
using Client.Console.Filters.Classes;
using Client.Console.Filters.Modifiers;
using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;

namespace Client.Console.Asserts.Classes
{
    public class ClassFilterAssertions : ReferenceTypeAssertions<IClassFilter, ClassFilterAssertions>
    {
        protected override string Identifier => nameof(IClassFilter);

        public ClassFilterAssertions(IClassFilter instance)
        {
            Subject = instance;
        }

        public virtual AndConstraint<ClassFilterAssertions> Inherit<T>(string because = "", params object[] becauseArgs)
            where T : class
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(x => x.Inherit<T>()))
                .FailWith($"Expected classes to have");

            return new AndConstraint<ClassFilterAssertions>(this);
        }

        public virtual AndConstraint<ClassFilterAssertions> Implement<T>(string because = "", params object[] becauseArgs)
            where T : class
        {
            return this.Implement(new List<Type> { typeof(T) });
        }

        public virtual AndConstraint<ClassFilterAssertions> Implement<T1, T2>(string because = "", params object[] becauseArgs)
            where T1 : class
        {
            throw new NotImplementedException();
        }

        public virtual AndConstraint<ClassFilterAssertions> Implement<T1, T2, T3>(string because = "", params object[] becauseArgs)
        {
            throw new NotImplementedException();
        }

        public virtual AndConstraint<ClassFilterAssertions> Implement<T1, T2, T3, T4>(string because = "", params object[] becauseArgs)
        {
            throw new NotImplementedException();
        }

        public virtual AndConstraint<ClassFilterAssertions> Implement<T1, T2, T3, T4, T5>(string because = "", params object[] becauseArgs)
        {
            throw new NotImplementedException();
        }

        public virtual AndConstraint<ClassFilterAssertions> Implement<T1, T2, T3, T4, T5, T6>(string because = "", params object[] becauseArgs)
        {
            throw new NotImplementedException();
        }

        public virtual AndConstraint<ClassFilterAssertions> BePublic(string because = "", params object[] becauseArgs)
        {
            return this.Are(ClassModifier.Public);
        }
        
        public virtual AndConstraint<ClassFilterAssertions> BeInternal(string because = "", params object[] becauseArgs)
        {
            return this.Are(ClassModifier.Internal);
        }

        public virtual AndConstraint<ClassFilterAssertions> BeSealed(string because = "", params object[] becauseArgs)
        {
            return this.Are(ClassModifier.Sealed);
        }

        public virtual AndConstraint<ClassFilterAssertions> BeAbstract(string because = "", params object[] becauseArgs)
        {
            return this.Are(ClassModifier.Abstract);
        }

        public virtual AndConstraint<ClassFilterAssertions> BePartial(string because = "", params object[] becauseArgs)
        {
            return this.Are(ClassModifier.Partial);
        }

        public virtual AndConstraint<ClassFilterAssertions> HaveAttribute<T>(string because = "", params object[] becauseArgs)
            where T : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T) });
        }

        public virtual AndConstraint<ClassFilterAssertions> HaveAttribute<T1, T2>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2) });
        }

        public virtual AndConstraint<ClassFilterAssertions> HaveAttribute<T1, T2, T3>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
            where T3 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2), typeof(T3) });
        }

        public virtual AndConstraint<ClassFilterAssertions> HaveAttribute<T1, T2, T3, T4>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
            where T3 : Attribute
            where T4 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2), typeof(T3), typeof(T4) });
        }

        public virtual AndConstraint<ClassFilterAssertions> HaveAttribute<T1, T2, T3, T4, T5>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
            where T3 : Attribute
            where T4 : Attribute
            where T5 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) });
        }

        public virtual AndConstraint<ClassFilterAssertions> HaveAttribute<T1, T2, T3, T4, T5, T6>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
            where T3 : Attribute
            where T4 : Attribute
            where T5 : Attribute
            where T6 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6) });
        }

        protected AndConstraint<ClassFilterAssertions> HaveAttribute(List<Type> attributes, string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(x => x.HasAttributes(attributes)))
                .FailWith($"Expected classes to have {AttributesToString()}");

            return new AndConstraint<ClassFilterAssertions>(this);

            string AttributesToString()
            {
                return attributes.Select(x => x.Name).Aggregate((a, b) => $"{a}, {b}");
            }
        }

        protected AndConstraint<ClassFilterAssertions> Are(ClassModifier modifier, string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(x => x.Is(modifier)))
                .FailWith($"Expected classes to have");

            return new AndConstraint<ClassFilterAssertions>(this);
        }

        protected AndConstraint<ClassFilterAssertions> Implement(List<Type> types, string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(x =>
                {
                    foreach (var type in types)
                    {
                        if (!x.Implements(type))
                            return false;
                    }

                    return true;
                }))
                .FailWith($"Expected classes to have");

            return new AndConstraint<ClassFilterAssertions>(this);
        }
    }
}