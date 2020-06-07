using System.Linq;
using Core.Components;
using Core.Modifiers;
using FluentAssertions;
using Xunit;

namespace Core.Tests.Components
{
    public class ConstructorTests
    {
        private readonly Constructor[] _constructors;

        public ConstructorTests()
        {
            _constructors = new Class(typeof(PublicStandaloneClass)).GetConstructors();
        }

        [Fact]
        public void Static()
        {
            _constructors.Where(x => x.Is(ConstructorModifier.Static)).Should().HaveCount(1);
        }

        [Fact]
        public void Internal()
        {
            _constructors.Where(x => x.Is(ConstructorModifier.Internal)).Should().HaveCount(1);
        }

        [Fact]
        public void Public()
        {
            _constructors.Where(x => x.Is(ConstructorModifier.Public)).Should().HaveCount(1);
        }

        [Fact]
        public void Args()
        {
            _constructors
                .First(x => x.Is(ConstructorModifier.Public))
                .Parameters
                .Should().HaveCount(2);
        }
    }
}