using System.Linq;
using Core.Components;
using Core.Modifiers;
using FluentAssertions;
using Xunit;

namespace Core.Tests.Components
{
    public class FieldTests
    {
        private readonly Field[] _fields;

        public FieldTests()
        {
            _fields = new Class(typeof(PublicSealedClass)).GetFields();
        }

        [Fact]
        public void Readonly()
        {
            _fields.Where(x => x.Is(FieldModifier.Readonly)).Should().HaveCount(1);
        }

        [Fact]
        public void PrivateReadonly()
        {
            _fields.Where(x => x.Is(FieldModifier.Readonly | FieldModifier.Private)).Should().HaveCount(1);
        }

        [Fact]
        public void PublicReadonly()
        {
            _fields.Where(x => x.Is(FieldModifier.Readonly | FieldModifier.Public)).Should().HaveCount(0);
        }

        [Fact]
        public void Protected()
        {
            _fields.Where(x => x.Is(FieldModifier.Protected)).Should().HaveCount(1);
        }

        [Fact]
        public void Const()
        {
            _fields.Where(x => x.Is(FieldModifier.Const)).Should().HaveCount(1);
        }
    }
}