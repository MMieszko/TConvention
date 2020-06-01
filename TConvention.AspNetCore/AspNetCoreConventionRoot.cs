using System.Reflection;
using TConvention.Core;

namespace TConvention.AspNetCore
{
    public class AspNetCoreConventionRoot : ConventionRoot
    {
        public AspNetCoreConventionRoot(Assembly assembly)
            : base(assembly)
        {
        }
    }
}