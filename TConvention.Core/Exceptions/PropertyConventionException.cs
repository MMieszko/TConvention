using System.Reflection;
using TConvention.Core.Conventions.Properties;

namespace TConvention.Core.Exceptions
{
    public class PropertyConventionException : ConventionException<PropertyConvention, PropertyInfo>
    {
        public PropertyConventionException(PropertyConvention convention, PropertyInfo component)
            : base(convention, component)
        {
        }
    }
}