using Core;
using Core.Extensions;
using Xunit;

namespace Client.Domain.ConventionTests
{
    public class EntitiesTests
    {
        [Fact]
        public void ShouldNotHavePublicParameterlessConstructors()
        {
            var entities = Arrange.ForAssembly(typeof(IEntity).Assembly)
                 .Inherit<IEntity>();

            entities.Constructors.Public().Should().NotBeParameterless();
            entities.Constructors.Public().Should().BeAtLeastOne();
        }

        [Fact]
        public void VehicleShouldBeSealed()
        {
                 Arrange
                .ForAssembly(typeof(IEntity).Assembly)
                .Concrete<Vehicle>()
                .Should()
                .BeSealed();
        }
    }
}
