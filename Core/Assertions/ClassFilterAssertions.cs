using System;
using System.Collections.Generic;
using System.Linq;
using Core.Filters.Classes;
using Core.Modifiers;
using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;

namespace Core.Assertions
{
    public class ClassFilterAssertions : ReferenceTypeAssertions<IClassFilter, ClassFilterAssertions>
    {
        protected override string Identifier => nameof(IClassFilter);

        public ClassFilterAssertions(IClassFilter instance)
        {
            Subject = instance;
        }

        /// <summary>
        /// Checks if classes inherit from given type
        /// </summary>
        public virtual AndConstraint<ClassFilterAssertions> Inherit<T>(bool includeBase = false, string because = "", params object[] becauseArgs)
            where T : class
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(@class => @class.Inherit<T>()))
                .FailWith($"Expected classes to have");

            return new AndConstraint<ClassFilterAssertions>(this);
        }

        /// <summary>
        /// Checks if classes implement from given interface type
        /// </summary>
        public virtual AndConstraint<ClassFilterAssertions> Implement<T>(string because = "", params object[] becauseArgs)
            where T : class
        {
            return this.Implement(new List<Type> { typeof(T) });
        }

        /// <summary>
        /// Checks if classes implement from given interface types
        /// </summary>
        public virtual AndConstraint<ClassFilterAssertions> Implement<T1, T2>(string because = "", params object[] becauseArgs)
            where T1 : class
            where T2 : class
        {
            return this.Implement(new List<Type> { typeof(T1), typeof(T2) });
        }

        /// <summary>
        /// Checks if classes implement from given interface types
        /// </summary>
        public virtual AndConstraint<ClassFilterAssertions> Implement<T1, T2, T3>(string because = "", params object[] becauseArgs)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return this.Implement(new List<Type> { typeof(T1), typeof(T2), typeof(T3) });
        }

        /// <summary>
        /// Checks if classes implement from given interface types
        /// </summary>
        public virtual AndConstraint<ClassFilterAssertions> Implement<T1, T2, T3, T4>(string because = "", params object[] becauseArgs)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return this.Implement(new List<Type> { typeof(T1), typeof(T2), typeof(T3), typeof(T4) });
        }

        /// <summary>
        /// Checks if classes implement from given interface types
        /// </summary>
        public virtual AndConstraint<ClassFilterAssertions> Implement<T1, T2, T3, T4, T5>(string because = "", params object[] becauseArgs)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return this.Implement(new List<Type> { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) });
        }

        /// <summary>
        /// Checks if classes implement from given interface types
        /// </summary>
        public virtual AndConstraint<ClassFilterAssertions> Implement<T1, T2, T3, T4, T5, T6>(string because = "", params object[] becauseArgs)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return this.Implement(new List<Type> { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6) });
        }

        /// <summary>
        /// Checks if classes are public
        /// </summary>
        public virtual AndConstraint<ClassFilterAssertions> BePublic(string because = "", params object[] becauseArgs)
        {
            return this.Be(ClassModifier.Public);
        }

        /// <summary>
        /// Checks if classes are internal
        /// </summary>
        public virtual AndConstraint<ClassFilterAssertions> BeInternal(string because = "", params object[] becauseArgs)
        {
            return this.Be(ClassModifier.Internal);
        }

        /// <summary>
        /// Checks if classes are sealed
        /// </summary>
        public virtual AndConstraint<ClassFilterAssertions> BeSealed(string because = "", params object[] becauseArgs)
        {
            return this.Be(ClassModifier.Sealed);
        }

        /// <summary>
        /// Checks if classes are abstract
        /// </summary>
        public virtual AndConstraint<ClassFilterAssertions> BeAbstract(string because = "", params object[] becauseArgs)
        {
            return this.Be(ClassModifier.Abstract);
        }

        /// <summary>
        /// Checks if classes are partial
        /// </summary>
        public virtual AndConstraint<ClassFilterAssertions> BePartial(string because = "", params object[] becauseArgs)
        {
            return this.Be(ClassModifier.Partial);
        }
        
        /// <summary>
        /// Checks if classes have attribute of given type
        /// </summary>
        public virtual AndConstraint<ClassFilterAssertions> HaveAttribute<T>(string because = "", params object[] becauseArgs)
            where T : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T) });
        }

        /// <summary>
        /// Checks if classes have attributes of given types
        /// </summary>
        public virtual AndConstraint<ClassFilterAssertions> HaveAttribute<T1, T2>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2) });
        }

        /// <summary>
        /// Checks if classes have attributes of given types
        /// </summary>
        public virtual AndConstraint<ClassFilterAssertions> HaveAttribute<T1, T2, T3>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
            where T3 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2), typeof(T3) });
        }

        /// <summary>
        /// Checks if classes have attributes of given types
        /// </summary>
        public virtual AndConstraint<ClassFilterAssertions> HaveAttribute<T1, T2, T3, T4>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
            where T3 : Attribute
            where T4 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2), typeof(T3), typeof(T4) });
        }

        /// <summary>
        /// Checks if classes have attributes of given types
        /// </summary>
        public virtual AndConstraint<ClassFilterAssertions> HaveAttribute<T1, T2, T3, T4, T5>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
            where T3 : Attribute
            where T4 : Attribute
            where T5 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) });
        }

        /// <summary>
        /// Checks if classes have attributes of given types
        /// </summary>
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

        /// <summary>
        /// Checks if classes are declared with give modifiers
        /// </summary>
        public AndConstraint<ClassFilterAssertions> Be(ClassModifier modifier, string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(@class => @class.Is(modifier)))
                .FailWith($"Expected classes to have");

            return new AndConstraint<ClassFilterAssertions>(this);
        }

        public AndConstraint<ClassFilterAssertions> BeAtLeastOne(string because = "", params object[] becauseArgs)
        {
            return this.HaveCount(count => count >= 1, because, becauseArgs);
        }

        public AndConstraint<ClassFilterAssertions> BeMaximumOne(string because = "", params object[] becauseArgs)
        {
            return this.HaveCount(count => count <= 1, because, becauseArgs);
        }

        public AndConstraint<ClassFilterAssertions> BeMaximum(int value, string because = "", params object[] becauseArgs)
        {
            return this.HaveCount(count => count <= value, because, becauseArgs);
        }

        public AndConstraint<ClassFilterAssertions> BeAtLeast(int value, string because = "", params object[] becauseArgs)
        {
            return this.HaveCount(count => count >= value, because, becauseArgs);
        }

        public AndConstraint<ClassFilterAssertions> NotExist(string because = "", params object[] becauseArgs)
        {
            return this.HaveCount(count => count == 0, because, becauseArgs);
        }

        protected AndConstraint<ClassFilterAssertions> HaveCount(Func<int, bool> countFunc, string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => countFunc(x.Length))
                .FailWith($"Expected classes to have. {because}");

            return new AndConstraint<ClassFilterAssertions>(this);
        }
        
        protected AndConstraint<ClassFilterAssertions> HaveAttribute(List<Type> attributes, string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(@class =>
                {
                    foreach (var attribute in attributes)
                    {
                        if (!@class.HasAttribute(attribute))
                            return false;
                    }

                    return true;

                }))
                .FailWith($"Expected classes to have {AttributesToString()}");

            return new AndConstraint<ClassFilterAssertions>(this);

            string AttributesToString()
            {
                return attributes.Select(x => x.Name).Aggregate((a, b) => $"{a}, {b}");
            }
        }

        protected AndConstraint<ClassFilterAssertions> Implement(List<Type> types, string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(@class =>
                {
                    foreach (var type in types)
                    {
                        if (!@class.Implements(type))
                            return false;
                    }

                    return true;
                }))
                .FailWith($"Expected classes to have");

            return new AndConstraint<ClassFilterAssertions>(this);
        }
    }
}