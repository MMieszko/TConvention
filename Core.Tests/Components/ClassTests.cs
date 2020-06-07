using System.Collections;
using System.Collections.Generic;
using Core.Components;
using Core.Modifiers;
using FluentAssertions;
using Xunit;

namespace Core.Tests.Components
{
    public class ClassTests
    {
        [Theory]
        [InlineData(ClassModifier.Public, true)]
        [InlineData(ClassModifier.Partial, false)]
        [InlineData(ClassModifier.Abstract, false)]
        [InlineData(ClassModifier.Internal, false)]
        [InlineData(ClassModifier.Sealed, false)]
        public void Is_PublicClass(ClassModifier modifier, bool expected)
        {
            var @class = new Class(typeof(PublicClass));

            var result = @class.Is(modifier);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(ClassModifier.Public, true)]
        [InlineData(ClassModifier.Partial, false)]
        [InlineData(ClassModifier.Abstract, true)]
        [InlineData(ClassModifier.Internal, false)]
        [InlineData(ClassModifier.Sealed, false)]
        public void Is_PublicAbstract(ClassModifier modifier, bool expected)
        {
            var @class = new Class(typeof(PublicAbstractClass));

            var result = @class.Is(modifier);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(ClassModifier.Public, true)]
        [InlineData(ClassModifier.Partial, false)]
        [InlineData(ClassModifier.Abstract, false)]
        [InlineData(ClassModifier.Internal, false)]
        [InlineData(ClassModifier.Sealed, true)]
        public void Is_PublicSealed(ClassModifier modifier, bool expected)
        {
            var @class = new Class(typeof(PublicSealedClass));

            var result = @class.Is(modifier);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(ClassModifier.Public, false)]
        [InlineData(ClassModifier.Partial, false)]
        [InlineData(ClassModifier.Abstract, false)]
        [InlineData(ClassModifier.Internal, true)]
        [InlineData(ClassModifier.Sealed, false)]
        public void Is_Internal(ClassModifier modifier, bool expected)
        {
            var @class = new Class(typeof(InternalClass));

            var result = @class.Is(modifier);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(ClassModifier.Public, true)]
        [InlineData(ClassModifier.Partial, false)]
        [InlineData(ClassModifier.Abstract, false)]
        [InlineData(ClassModifier.Internal, false)]
        [InlineData(ClassModifier.Sealed, true)]
        public void Is_Sealed(ClassModifier modifier, bool expected)
        {
            var @class = new Class(typeof(PublicSealedClass));

            var result = @class.Is(modifier);

            result.Should().Be(expected);
        }

        [Fact]
        public void Inherit()
        {
            var @class = new Class(typeof(PublicInheritFromStandaloneClass));

            var result = @class.Inherit<PublicStandaloneClass>();

            result.Should().BeTrue();
        }

        [Fact]
        public void Implements()
        {
            var @class = new Class(typeof(PublicClassImplementsStandaloneInterface));

            var result = @class.Implements<IPublicStandaloneInterface>();

            result.Should().BeTrue();
        }

        [Fact]
        public void HasAttribute()
        {
            var @class = new Class(typeof(PublicClassWithTestAttribute));

            var result = @class.HasAttribute<TestAttribute>();

            result.Should().BeTrue();
        }
    }
}