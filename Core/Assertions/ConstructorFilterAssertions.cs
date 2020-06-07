using System;
using System.Linq;
using Core.Components;
using Core.Filters;
using Core.Filters.Constructors;
using Core.Modifiers;
using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;

namespace Core.Assertions
{
    public class ConstructorFilterAssertions : ReferenceTypeAssertions<IConstructorFilter, ConstructorFilterAssertions>
    {
        protected override string Identifier => nameof(IConstructorFilter);

        public ConstructorFilterAssertions(IConstructorFilter instance)
        {
            this.Subject = instance;
        }

        public AndConstraint<ConstructorFilterAssertions> BePublic(string because = "", params object[] becauseArgs)
        {
            return this.Be(ConstructorModifier.Public);
        }

        public AndConstraint<ConstructorFilterAssertions> BeInternal(string because = "", params object[] becauseArgs)
        {
            return this.Be(ConstructorModifier.Internal);
        }

        public AndConstraint<ConstructorFilterAssertions> BeProtected(string because = "", params object[] becauseArgs)
        {
            return this.Be(ConstructorModifier.Protected);
        }

        public AndConstraint<ConstructorFilterAssertions> BePrivate(string because = "", params object[] becauseArgs)
        {
            return this.Be(ConstructorModifier.Private);
        }

        public AndConstraint<ConstructorFilterAssertions> BeStatic(string because = "", params object[] becauseArgs)
        {
            return this.Be(ConstructorModifier.Static);
        }

        public AndConstraint<ConstructorFilterAssertions> BeParameterless(string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(property => property.IsParameterless))
                .FailWith($"Expected classes to have. {because}");

            return new AndConstraint<ConstructorFilterAssertions>(this);
        }

        public AndConstraint<ConstructorFilterAssertions> NotBeParameterless(string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(property => !property.IsParameterless))
                .FailWith($"Expected classes to have. {because}");

            return new AndConstraint<ConstructorFilterAssertions>(this);
        }

        public AndConstraint<ConstructorFilterAssertions> BeAtLeastOne(string because = "", params object[] becauseArgs)
        {
            return this.HaveCount(count => count >= 1, because, becauseArgs);
        }

        public AndConstraint<ConstructorFilterAssertions> BeMaximumOne(string because = "", params object[] becauseArgs)
        {
            return this.HaveCount(count => count <= 1, because, becauseArgs);
        }

        public AndConstraint<ConstructorFilterAssertions> BeMaximum(int value, string because = "", params object[] becauseArgs)
        {
            return this.HaveCount(count => count <= value, because, becauseArgs);
        }

        public AndConstraint<ConstructorFilterAssertions> BeAtLeast(int value, string because = "", params object[] becauseArgs)
        {
            return this.HaveCount(count => count >= value, because, becauseArgs);
        }

        public AndConstraint<ConstructorFilterAssertions> NotExist(string because = "", params object[] becauseArgs)
        {
            return this.HaveCount(count => count == 0, because, becauseArgs);
        }

        protected AndConstraint<ConstructorFilterAssertions> HaveCount(Func<int, bool> countFunc, string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => countFunc(x.Length))
                .FailWith($"Expected classes to have. {because}");

            return new AndConstraint<ConstructorFilterAssertions>(this);
        }

        public AndConstraint<ConstructorFilterAssertions> Be(ConstructorModifier modifier, string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(property => property.Is(modifier)))
                .FailWith($"Expected classes to have. {because}");

            return new AndConstraint<ConstructorFilterAssertions>(this);
        }
    }
}