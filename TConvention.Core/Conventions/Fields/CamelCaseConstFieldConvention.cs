using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TConvention.Core.Conventions.Fields
{
    public class CamelCaseConstFieldConvention : FieldConvention
    {
        public override IEnumerable<FieldInfo> Filter(List<FieldInfo> components)
        {
            return components.Where(x => x.IsLiteral && !x.IsInitOnly);
        }

        public override bool IsValid(FieldInfo component)
        {
            throw new System.NotImplementedException();
        }
    }
}