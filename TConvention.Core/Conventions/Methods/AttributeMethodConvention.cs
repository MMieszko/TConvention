using System;
using System.Collections.Generic;
using System.Reflection;

namespace TConvention.Core.Conventions.Methods
{
    public class AttributeMethodConvention<TAttribute> : MethodConvention
    {
        public override IEnumerable<MethodInfo> Filter(List<MethodInfo> components)
        {
            return base.Filter(components);
        }

        public override bool IsValid(MethodInfo component)
        {
            throw new NotImplementedException();
        }
    }
}