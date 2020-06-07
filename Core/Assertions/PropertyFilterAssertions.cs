using System;
using System.Collections.Generic;
using System.Linq;
using Core.Filters.Properties;
using Core.Modifiers;
using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;

namespace Core.Assertions
{
    public class PropertyFilterAssertions : ReferenceTypeAssertions<IPropertyFilter, PropertyFilterAssertions>
    {
        protected override string Identifier => nameof(IPropertyFilter);

        public PropertyFilterAssertions(IPropertyFilter instance)
        {
            this.Subject = instance;
        }

        public virtual AndConstraint<PropertyFilterAssertions> BePublicReadonly(string because = "", params object[] becauseArgs)
        {
            return this.Be(PropertyModifier.PublicGet | PropertyModifier.Readonly);
        }

        public virtual AndConstraint<PropertyFilterAssertions> BePublicWithPrivateSet(string because = "", params object[] becauseArgs)
        {
            return this.Be(PropertyModifier.PublicGet | PropertyModifier.PrivateSet);
        }

        public virtual AndConstraint<PropertyFilterAssertions> BeProtectedWithPrivateSet(string because = "", params object[] becauseArgs)
        {
            return this.Be(PropertyModifier.ProtectedGet | PropertyModifier.PrivateSet);
        }

        public virtual AndConstraint<PropertyFilterAssertions> BeProtectedReadonly(string because = "", params object[] becauseArgs)
        {
            return this.Be(PropertyModifier.ProtectedGet | PropertyModifier.Readonly);
        }

        public virtual AndConstraint<PropertyFilterAssertions> BeAbstract(string because = "", params object[] becauseArgs)
        {
            return this.Be(PropertyModifier.Abstract);
        }
        public virtual AndConstraint<PropertyFilterAssertions> BeStatic(string because = "", params object[] becauseArgs)
        {
            return this.Be(PropertyModifier.Static);
        }

        public virtual AndConstraint<PropertyFilterAssertions> BePublic(string because = "", params object[] becauseArgs)
        {
            return this.Be(PropertyModifier.PublicGet | PropertyModifier.PublicSet);
        }

        public virtual AndConstraint<PropertyFilterAssertions> BeProtected(string because = "", params object[] becauseArgs)
        {
            return this.Be(PropertyModifier.ProtectedGet | PropertyModifier.ProtectedSet);
        }

        public virtual AndConstraint<PropertyFilterAssertions> BePrivate(string because = "", params object[] becauseArgs)
        {
            return this.Be(PropertyModifier.PrivateGet | PropertyModifier.PrivateSet);
        }

        public virtual AndConstraint<PropertyFilterAssertions> NotExist(string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => !x.Any())
                .FailWith($"Expected such methods not exists. {because}");

            return new AndConstraint<PropertyFilterAssertions>(this);
        }

        public virtual AndConstraint<PropertyFilterAssertions> HaveAttribute<T>(string because = "", params object[] becauseArgs)
            where T : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T) });
        }

        public virtual AndConstraint<PropertyFilterAssertions> HaveAttribute<T1, T2>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2) });
        }

        public virtual AndConstraint<PropertyFilterAssertions> HaveAttribute<T1, T2, T3>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
            where T3 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2), typeof(T3) });
        }

        public virtual AndConstraint<PropertyFilterAssertions> HaveAttribute<T1, T2, T3, T4>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
            where T3 : Attribute
            where T4 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2), typeof(T3), typeof(T4) });
        }

        public virtual AndConstraint<PropertyFilterAssertions> HaveAttribute<T1, T2, T3, T4, T5>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
            where T3 : Attribute
            where T4 : Attribute
            where T5 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) });
        }

        public virtual AndConstraint<PropertyFilterAssertions> HaveAttribute<T1, T2, T3, T4, T5, T6>(string because = "", params object[] becauseArgs)
            where T1 : Attribute
            where T2 : Attribute
            where T3 : Attribute
            where T4 : Attribute
            where T5 : Attribute
            where T6 : Attribute
        {
            return this.HaveAttribute(new List<Type> { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6) });
        }

        protected AndConstraint<PropertyFilterAssertions> HaveAttribute(List<Type> attributes, string because = "", params object[] becauseArgs)
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

            return new AndConstraint<PropertyFilterAssertions>(this);

            string AttributesToString()
            {
                return attributes.Select(x => x.Name).Aggregate((a, b) => $"{a}, {b}");
            }
        }

        public virtual AndConstraint<PropertyFilterAssertions> Be(PropertyModifier modifier, string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Components)
                .ForCondition(x => x.All(property => property.Is(modifier)))
                .FailWith($"Expected classes to have. {because}");

            return new AndConstraint<PropertyFilterAssertions>(this);
        }

    }
}