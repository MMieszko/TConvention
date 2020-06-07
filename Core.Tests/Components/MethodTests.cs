using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Core.Components;
using Core.Modifiers;
using FluentAssertions;
using Xunit;

namespace Core.Tests.Components
{
    public class MethodTests
    {
        private readonly Method[] _methods;

        public MethodTests()
        {
            _methods = new Class(typeof(PublicClass)).GetMethods();
        }

        [Fact]
        public void Returns()
        {
            var method = new Method(typeof(PublicClass).GetMethod(nameof(PublicClass.InternalReturnStringMethod), BindingFlags.Instance | BindingFlags.NonPublic));

            method.Returns<string>().Should().BeTrue();
        }

        [Fact]
        public void Returns_Generic()
        {
            var method = new Method(typeof(PublicAbstractClass).GetMethod(nameof(PublicAbstractClass.PublicReturnTaskOfString)));

            method.ReturnsAsync<string>().Should().BeTrue();
        }

        [Fact]
        public void ReturnsAsync()
        {
            var method = new Method(typeof(PublicAbstractClass).GetMethod(nameof(PublicAbstractClass.PublicReturnTaskOfString)));

            method.ReturnsAsync().Should().BeTrue();
        }

        [Fact]
        public void Is_Public()
        {
            var count = _methods.Count(x => x.Is(MethodModifier.Public));

            count.Should().Be(3);
        }

        [Fact]
        public void Is_Internal()
        {
            var publicCount = _methods.Count(x => x.Is(MethodModifier.Internal));

            publicCount.Should().Be(1);
        }

        [Fact]
        public void Is_Protected()
        {
            var count = _methods.Count(x => x.Is(MethodModifier.Protected));

            count.Should().Be(1);
        }

        [Fact]
        public void Is_Private()
        {
            var count = _methods.Count(x => x.Is(MethodModifier.Private));

            count.Should().Be(2);
        }

        [Fact]
        public void Is_Async()
        {
            var count = _methods.Count(x => x.Is(MethodModifier.Async));

            count.Should().Be(1);
        }

        [Fact]
        public void Is_Static()
        {
            var count = _methods.Count(x => x.Is(MethodModifier.Static));

            count.Should().Be(2);
        }

        [Fact]
        public void Is_PrivateStatic()
        {
            var count = _methods.Count(x => x.Is(MethodModifier.Static | MethodModifier.Private));

            count.Should().Be(1);
        }

        [Fact]
        public void Is_ProtectedStatic()
        {
            var count = _methods.Count(x => x.Is(MethodModifier.Static | MethodModifier.Protected));

            count.Should().Be(0);
        }
    }
}