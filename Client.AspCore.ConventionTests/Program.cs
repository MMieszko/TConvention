
using System.Reflection;
using System.Threading.Tasks;
using Client.AspCore.Controllers;
using Core;
using Core.Extensions;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace Client.AspCore.ConventionTests
{
    public class Test1
    {
        [Fact]
        public void MyResponseConvention()
        {
            var response = Arrange
                .ForAssembly(typeof(Startup).Assembly)
                .Concrete<IResponse>();

            response.Properties.Should().BePublicReadonly();
        }

        [Fact]
        public void ControllersConvention()
        {
            //Arrange
            var controllers = Arrange
                .ForAssembly(typeof(Startup).Assembly)
                .Public()
                .EndWith("Controller");

            controllers.Should().Inherit<ApiController>("All controllers must inherit base");

            controllers.Methods.Should().BePublic("Controller contains only public methods");
            controllers.Methods.Should().ReturnAsync<IResponse>();
            controllers.Methods.Should().HaveAttribute<HttpMethodAttribute>("All endpoints explicit says the method");
            controllers.Methods.Should().HaveAttribute<RouteAttribute>("All endpoints explicit says the method");
        }
    }
}
