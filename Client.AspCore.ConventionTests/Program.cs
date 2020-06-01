using System;
using System.Threading.Tasks;
using Client.AspCore.Controllers;
using Client.Console.Asserts;
using Client.Console.Filters.Modifiers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Xunit;

namespace Client.AspCore.ConventionTests
{
    public class Test1
    {
        [Fact]
        public void ControllersConvention()
        {
            ConventionAssert
                .ForAssembly(typeof(Startup).Assembly)
                .Ignore<Program>()
                .Ignore<Startup>()
                .Classes(filter => filter.WithEnds("Controller"),
                         assert => assert.HasAttribute<ApiControllerAttribute>())
                .Constructors(x => x.HasMaximum(1))
                .Methods(assert => assert.ReturnsAsync())
                .Assert();
        }
    }
}
