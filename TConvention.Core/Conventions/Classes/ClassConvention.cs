using System;
using System.Collections.Generic;
using System.Linq;

namespace TConvention.Core.Conventions.Classes
{
    public abstract class ClassConvention : ComponentConvention<ClassComponent, Type>
    {
        public override IEnumerable<Type> Filter(List<Type> components)
        {
            return components.Where(x => x.IsClass);
        }
    }
}