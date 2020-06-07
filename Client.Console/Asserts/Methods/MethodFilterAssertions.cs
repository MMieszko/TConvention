using System.Linq;
using System.Threading.Tasks;
using Client.Console.Filters.Methods;
using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;

namespace Client.Console.Asserts.Methods
{
    public class MethodFilterAssertions : ReferenceTypeAssertions<IMethodsFilter, MethodFilterAssertions>
    {
        protected override string Identifier => nameof(IMethodsFilter);

        public MethodFilterAssertions(IMethodsFilter instance)
        {
            Subject = instance;
        }

        public virtual AndConstraint<MethodFilterAssertions> Returns<T>(string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Methods)
                .ForCondition(x => x.All(x => x.ReturnType == typeof(T)))
                .FailWith($"Expected method to return {typeof(T).Name}");

            return new AndConstraint<MethodFilterAssertions>(this);
        }

        public virtual AndConstraint<MethodFilterAssertions> ReturnsAsync(string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Methods)
                .ForCondition(x => x.All(x => x.ReturnType == typeof(Task)))
                .FailWith($"Expected method to return async");

            return new AndConstraint<MethodFilterAssertions>(this);
        }

        public virtual AndConstraint<MethodFilterAssertions> ReturnsAsync<T>(string because = "", params object[] becauseArgs)
        {
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .Given(() => Subject.Methods)
                .ForCondition(x => x.All(x => x.ReturnType == typeof(Task<T>)))
                .FailWith($"Expected method to return Task of {typeof(T).Name}");

            return new AndConstraint<MethodFilterAssertions>(this);
        }
    }
}