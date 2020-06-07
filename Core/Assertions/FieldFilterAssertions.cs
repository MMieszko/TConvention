using System.Linq;
using Core.Filters.Fields;
using Core.Modifiers;
using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;

namespace Core.Assertions
{
    public class FieldFilterAssertions : ReferenceTypeAssertions<IFieldFilter, FieldFilterAssertions>
    {
        protected override string Identifier => nameof(IFieldFilter);

        public FieldFilterAssertions(IFieldFilter instance)
        {
            this.Subject = instance;
        }

        public virtual AndConstraint<FieldFilterAssertions> BeStatic(string because = "", params object[] becauseArgs)
        {
            return this.Be(FieldModifier.Static);
        }

        public virtual AndConstraint<FieldFilterAssertions> BePublic(string because = "", params object[] becauseArgs)
        {
            return this.Be(FieldModifier.Public);
        }

        public virtual AndConstraint<FieldFilterAssertions> BeProtected(string because = "", params object[] becauseArgs)
        {
            return this.Be(FieldModifier.Protected);
        }

        public virtual AndConstraint<FieldFilterAssertions> BePrivate(string because = "", params object[] becauseArgs)
        {
            return this.Be(FieldModifier.Private);
        }

        public virtual AndConstraint<FieldFilterAssertions> Be(FieldModifier modifier, string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(property => property.Is(modifier)))
                .FailWith($"Expected classes to have. {because}");

            return new AndConstraint<FieldFilterAssertions>(this);
        }
    }
}