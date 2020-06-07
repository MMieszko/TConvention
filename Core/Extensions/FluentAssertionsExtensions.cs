using Core.Assertions;
using Core.Filters.Classes;
using Core.Filters.Constructors;
using Core.Filters.Fields;
using Core.Filters.Methods;
using Core.Filters.Properties;

namespace Core.Extensions
{
    public static class FluentAssertionsExtensions
    {
        public static ClassFilterAssertions Should(this IClassFilter instance)
        {
            return new ClassFilterAssertions(instance);

        }
        public static MethodFilterAssertions Should(this IMethodsFilter instance)
        {
            return new MethodFilterAssertions(instance);
        }

        public static PropertyFilterAssertions Should(this IPropertyFilter instance)
        {
            return new PropertyFilterAssertions(instance);
        }

        public static FieldFilterAssertions Should(this IFieldFilter instance)
        {
            return new FieldFilterAssertions(instance);
        }

        public static ConstructorFilterAssertions Should(this IConstructorFilter instance)
        {
            return new ConstructorFilterAssertions(instance);
        }
    }
}