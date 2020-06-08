using Core;
using Core.Extensions;
using Xunit;

namespace Client.Application.ConventionTests
{
    public class ControllerTests
    {
        [Fact]
        public void ControllerShouldInheritBase()
        {
            var controller = Arrange
                .ForAssembly(typeof(ApplicationController).Assembly)
                .Ignore<ApplicationController>()
                .EndWith("Controller");

            controller.Should().Inherit<ApplicationController>();
        }
    }
}
