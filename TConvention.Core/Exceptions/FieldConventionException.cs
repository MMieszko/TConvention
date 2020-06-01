using System.Reflection;
using TConvention.Core.Conventions.Fields;

namespace TConvention.Core.Exceptions
{
    public class FieldConventionException : ConventionException<FieldConvention, FieldInfo>
    {
        public FieldConventionException(FieldConvention convention, FieldInfo component)
            : base(convention, component)
        {
        }
    }
}