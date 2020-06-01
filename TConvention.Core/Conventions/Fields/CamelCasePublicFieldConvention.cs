using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TConvention.Core.Conventions.Fields
{
    public class CamelCasePublicFieldConvention : FieldConvention
    {
        public override IEnumerable<FieldInfo> Filter(List<FieldInfo> components)
        {
            return components.Where(x => x.IsPublic);
        }

        public override bool IsValid(FieldInfo component)
        {
            throw new NotImplementedException();
        }
    }
}