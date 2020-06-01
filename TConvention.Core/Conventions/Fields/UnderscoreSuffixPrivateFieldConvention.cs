using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TConvention.Core.Conventions.Fields
{
    public class UnderscoreSuffixPrivateFieldConvention : FieldConvention
    {
        public override IEnumerable<FieldInfo> Filter(List<FieldInfo> components)
        {
            return components.Where(x => x.IsPrivate);
        }

        public override bool IsValid(FieldInfo component)
        {
            return component.Name.StartsWith("_");
        }
    }
}