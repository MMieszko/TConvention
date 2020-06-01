using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Client.Console;
using Client.Console.Asserts;
using Client.Console.Filters.Methods;
using Client.Console.Filters.Modifiers;

namespace ElCliente
{
    public static class Program
    {



        static void Main(string[] args)
        {
            
            //ConventionAssert
            //    .ForAssembly(typeof(Loco).Assembly)
            //    .All()
            //    .Methods(filter =>
            //            filter.WithModifier(MethodModifier.Abstract)
            //                  .WithModifier(MethodModifier.Internal),
            //        assert => assert.ReturnsAsync())
            //    .Properties(assert => assert.HasMaximum(PropertyModifier.Static, 0));




            //ConventionAssert
            //.ForAssembly(typeof(Loco).Assembly)
            //.All()
            //.Methods(x =>
            //{
            //    x.WithModifier(MethodModifier.Public, x =>
            //    {
            //        x.HasMaximum(4)
            //         .ReturnsAsync()
            //         .HasAttribute<ApiControllerAttribute>();
            //    });

            //    x.WithModifier(MethodModifier.Private, x =>
            //    {
            //        x.ReturnsAsync<Response>()
            //         .HasMaximumArgumentsCount(5);
            //    });
            //});
        }

        internal class ApiControllerAttribute : Attribute
        {
        }

        public class Loco
        {
            public void M1()
            {

            }

            public object M2()
            {
                return null;
            }

            protected void M3()
            {

            }
        }

        public class HttpGet : Attribute { }

        public class ApiController { }

        public class Route : Attribute { }


        public class UserController : ApiController
        {

        }

        public class Response
        {

        }
    }
}
