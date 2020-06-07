using System.Linq;
using Core.Components;
using Core.Modifiers;
using FluentAssertions;
using Xunit;

namespace Core.Tests.Components
{
    public class PropertyTests
    {
        private readonly Property[] _properties;

        public PropertyTests()
        {
            _properties = new Class(typeof(PublicAbstractClass)).GetProperties();
        }

        [Fact]
        public void FullPublic()
        {
            _properties.Where(x => x.Is(PropertyModifier.PublicGet | PropertyModifier.PublicSet)).Should().HaveCount(2);
        }

        [Fact]
        public void PublicWithPrivateGetter()
        {
            _properties.Where(x => x.Is(PropertyModifier.PublicGet | PropertyModifier.PrivateSet)).Should()
                .HaveCount(1);
        }

        [Fact]
        public void PublicWithProtectedGetter()
        {
            _properties.Where(x => x.Is(PropertyModifier.PublicGet | PropertyModifier.ProtectedSet)).Should()
                .HaveCount(1);
        }

        [Fact]
        public void PublicReadonly()
        {
            _properties.Where(x => x.Is(PropertyModifier.PublicGet | PropertyModifier.Readonly)).Should().HaveCount(1);
        }

        [Fact]
        public void PrivateReadonly()
        {
            _properties.Where(x => x.Is(PropertyModifier.PrivateSet | PropertyModifier.Readonly)).Should().HaveCount(0);
        }

        [Fact]
        public void PublicStatic()
        {
            _properties.Where(x => x.Is(PropertyModifier.PublicSet | PropertyModifier.PublicGet | PropertyModifier.Static)).Should().HaveCount(1);
        }

        [Fact]
        public void ProtectedAbstractReadonly()
        {
            _properties.Where(x => x.Is(PropertyModifier.ProtectedGet | PropertyModifier.Readonly | PropertyModifier.Abstract)).Should().HaveCount(1);
        }
    }
}