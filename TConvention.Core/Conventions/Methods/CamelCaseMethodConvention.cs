using System.Collections.Generic;
using System.Reflection;

namespace TConvention.Core.Conventions.Methods
{
    public class CamelCaseMethodConvention : MethodConvention
    {
        public override IEnumerable<MethodInfo> Filter(List<MethodInfo> components)
        {
            return components;
        }

        public override bool IsValid(MethodInfo method)
        {
            return method.Name.StartsWith("");
        }
    }
}