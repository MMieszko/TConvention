using System.Reflection;
using TConvention.Core.Conventions;

namespace TConvention.Core.Exceptions
{
    public class MethodConventionException : ConventionException<MethodConvention, MethodBase>
    {
        public MethodConventionException(MethodConvention convention, MethodBase component)
            : base(convention, component)
        {
        }
    }
}