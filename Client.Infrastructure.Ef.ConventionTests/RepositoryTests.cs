using System;
using Client.Domain;
using Core;
using Core.Extensions;
using FluentAssertions;
using Xunit;

namespace Client.Infrastructure.Ef.ConventionTests
{
    public class RepositoryTests
    {
        [Fact]
        public void RepositoriesShouldNotHavePrivateMethods()
        {
            var repositories = Arrange.ForAssembly(typeof(EfContext).Assembly)
                .Inherit<IRepository>();

            repositories.Methods.Should().BePublic();
       }

        [Fact]
        public void ContextShouldNotBePublic()
        {
            var repositories = Arrange.ForAssembly(typeof(EfContext).Assembly)
                .Inherit<IRepository>();

            repositories.Fields.WithType<EfContext>().Should().BeProtected();
        }
    }
}
