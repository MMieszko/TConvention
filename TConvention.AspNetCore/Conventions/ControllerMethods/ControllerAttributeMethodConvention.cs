using System.Collections.Generic;
using System.Reflection;
using TConvention.Core.Conventions.Methods;

namespace TConvention.AspNetCore.Conventions
{
    public class ControllerAttributeMethodConvention<TAttribute> : AttributeMethodConvention<TAttribute>
    {
        public override IEnumerable<MethodInfo> Filter(List<MethodInfo> components)
        {
            return base.Filter(components);
        }
    }
}