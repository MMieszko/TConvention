using System;
using System.Collections.Generic;
using System.Linq;
using Core.Filters.Methods;
using Core.Modifiers;
using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;

namespace Core.Assertions
{
    public class MethodFilterAssertions : ReferenceTypeAssertions<IMethodsFilter, MethodFilterAssertions>
    {
        protected override string Identifier => nameof(IMethodsFilter);

        public MethodFilterAssertions(IMethodsFilter instance)
        {
            Subject = instance;
        }

        public virtual AndConstraint<MethodFilterAssertions> BePublic(string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(method => method.Is(MethodModifier.Public)))
                .FailWith($"Expected such methods not exists. {because}");

            return new AndConstraint<MethodFilterAssertions>(this);
        }

        public virtual AndConstraint<MethodFilterAssertions> BeProtected(string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(method => method.Is(MethodModifier.Protected)))
                .FailWith($"Expected such methods not exists. {because}");

            return new AndConstraint<MethodFilterAssertions>(this);
        }

        public virtual AndConstraint<MethodFilterAssertions> BePrivate(string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(method => method.Is(MethodModifier.Private)))
                .FailWith($"Expected such methods not exists. {because}");

            return new AndConstraint<MethodFilterAssertions>(this);
        }

        public virtual AndConstraint<MethodFilterAssertions> Return<T>(string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(method => method.Returns<T>()))
                .FailWith($"Expected method to return {typeof(T).Name}");

            return new AndConstraint<MethodFilterAssertions>(this);
        }

        public virtual AndConstraint<MethodFilterAssertions> ReturnAsync(string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(method => method.ReturnsAsync()))
                .FailWith($"Expected method to return async");

            return new AndConstraint<MethodFilterAssertions>(this);
        }

        public virtual AndConstraint<MethodFilterAssertions> BeVoid(string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(method => method.IsVoid))
                .FailWith($"Expected method to return async");

            return new AndConstraint<MethodFilterAssertions>(this);
        }

        public virtual AndConstraint<MethodFilterAssertions> NotBeVoid(string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(method => !method.IsVoid))
                .FailWith($"Expected method to return async");

            return new AndConstraint<MethodFilterAssertions>(this);
        }

        public virtual AndConstraint<MethodFilterAssertions> ReturnAsync<T>(string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(method => method.ReturnsAsync<T>()))
                .FailWith($"Expected method to return Task of {typeof(T).Name}");

            return new AndConstraint<MethodFilterAssertions>(this);
        }

        public virtual AndConstraint<MethodFilterAssertions> ReturnsSyncOrAsync<T>(string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(method => method.ReturnsSyncOrAsync<T>()))
                .FailWith($"Expected method to return Task of {typeof(T).Name}");

            return new AndConstraint<MethodFilterAssertions>(this);
        }

        public virtual AndConstraint<MethodFilterAssertions> HaveAttribute<T>(string because = "", params object[] becauseArgs)
            where T : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T) });
        }

        public virtual AndConstraint<MethodFilterAssertions> HaveAttribute<T1, T2>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2) });
        }

        public virtual AndConstraint<MethodFilterAssertions> HaveAttribute<T1, T2, T3>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
            where T3 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2), typeof(T3) });
        }

        public virtual AndConstraint<MethodFilterAssertions> HaveAttribute<T1, T2, T3, T4>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
            where T3 : Attribute
            where T4 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2), typeof(T3), typeof(T4) });
        }

        public virtual AndConstraint<MethodFilterAssertions> HaveAttribute<T1, T2, T3, T4, T5>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
            where T3 : Attribute
            where T4 : Attribute
            where T5 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) });
        }

        public virtual AndConstraint<MethodFilterAssertions> HaveAttribute<T1, T2, T3, T4, T5, T6>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
            where T3 : Attribute
            where T4 : Attribute
            where T5 : Attribute
            where T6 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6) });
        }

        public AndConstraint<MethodFilterAssertions> BeAtLeastOne(string because = "", params object[] becauseArgs)
        {
            return this.HaveCount(count => count >= 1, because, becauseArgs);
        }

        public AndConstraint<MethodFilterAssertions> BeMaximumOne(string because = "", params object[] becauseArgs)
        {
            return this.HaveCount(count => count <= 1, because, becauseArgs);
        }

        public AndConstraint<MethodFilterAssertions> BeMaximum(int value, string because = "", params object[] becauseArgs)
        {
            return this.HaveCount(count => count <= value, because, becauseArgs);
        }

        public AndConstraint<MethodFilterAssertions> BeAtLeast(int value, string because = "", params object[] becauseArgs)
        {
            return this.HaveCount(count => count >= value, because, becauseArgs);
        }

        public AndConstraint<MethodFilterAssertions> NotExist(string because = "", params object[] becauseArgs)
        {
            return this.HaveCount(count => count == 0, because, becauseArgs);
        }

        protected AndConstraint<MethodFilterAssertions> HaveCount(Func<int, bool> countFunc, string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => countFunc(x.Length))
                .FailWith($"Expected classes to have. {because}");

            return new AndConstraint<MethodFilterAssertions>(this);
        }

        protected AndConstraint<MethodFilterAssertions> HaveAttribute(List<Type> attributes, string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(method =>
                {
                    foreach (var attribute in attributes)
                    {
                        if (!method.HasAttribute(attribute))
                            return false;
                    }

                    return true;
                }))
                .FailWith($"Expected classes to have {AttributesToString()}. {because}");

            return new AndConstraint<MethodFilterAssertions>(this);

            string AttributesToString()
            {
                return attributes.Select(x => x.Name).Aggregate((a, b) => $"{a}, {b}");
            }
        }
    }
}