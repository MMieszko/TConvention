using Core;
using Core.Extensions;
using Xunit;

namespace Client.Domain.ConventionTests
{
    public class ValueObjectTests
    {
        [Fact]
        public void ValueObjectShouldBeImmutable()
        {
            var valueObjects = Arrange
                .ForAssembly(typeof(ValueObject).Assembly)
                .Inherit<ValueObject>();

            valueObjects.Properties.Should().BeReadonly();
            valueObjects.Methods.Should().NotBeVoid();
            valueObjects.Constructors.Should().NotBeParameterless();
        }
    }
}