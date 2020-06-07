using System.Linq;
using Core.Components;
using Core.Filters.Methods;
using Core.Tests.Components;
using FluentAssertions;
using Xunit;

namespace Core.Tests.Filters
{
    public class MethodFilterTests
    {
        private readonly IMethodsFilter _filter;

        public MethodFilterTests()
        {
            _filter = new MethodFilter(new Class(typeof(TestAttribute)).GetMethods());
        }

        [Fact]
        public void WhichAnyReturnType()
        {
            var filter = _filter.WhichAnyReturnType();

            filter.Components.Should().HaveCount(2);
        }
    }
}