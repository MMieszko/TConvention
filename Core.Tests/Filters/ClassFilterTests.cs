using System;
using System.Collections.Generic;
using System.Linq;
using Core.Components;
using Core.Filters.Classes;
using Core.Tests.Components;
using FluentAssertions;
using Xunit;

namespace Core.Tests.Filters
{
    public class ClassFilterTests
    {
        private readonly Class[] _classes;

        public ClassFilterTests()
        {
            _classes = new List<Type>
            {
                typeof(PublicClass), typeof(InternalClass), typeof(PublicAbstractClass),
                typeof(PublicSealedClass), typeof(PublicPartialClass), typeof(PublicStandaloneClass),
                typeof(PublicInheritFromStandaloneClass), typeof(PublicClassImplementsStandaloneInterface),
                typeof(TestAttribute), typeof(PublicClassWithTestAttribute)
            }.Select(x => (Class)x).ToArray();
        }

        [Fact]
        public void Ignore()
        {
            IClassFilter filter = new ClassFilter(_classes);

            filter = filter.Ignore<PublicClass, InternalClass>();

            filter.Components.Should().HaveCount(8);
        }

        [Fact]
        public void Concrete()
        {
            IClassFilter filter = new ClassFilter(_classes);

            filter = filter.Concrete<PublicSealedClass>();

            filter.Components.Should().HaveCount(1);
        }

        [Fact]
        public void Inherit()
        {
            IClassFilter filter = new ClassFilter(_classes);

            filter = filter.Inherit<PublicInheritFromStandaloneClass>();

            filter.Components.Should().HaveCount(0);
        }

        [Fact]
        public void Implements()
        {
            IClassFilter filter = new ClassFilter(_classes);

            filter = filter.Implements<IPublicStandaloneInterface>();

            filter.Components.Should().HaveCount(1);
        }

        [Fact]
        public void HasAttribute()
        {
            IClassFilter filter = new ClassFilter(_classes);

            filter = filter.WithAttribute<TestAttribute>();

            filter.Components.Should().HaveCount(1);
        }
    }
}