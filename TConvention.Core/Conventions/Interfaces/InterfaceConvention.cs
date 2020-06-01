using System;
using System.Collections.Generic;
using System.Linq;

namespace TConvention.Core.Conventions.Interfaces
{
    public abstract class InterfaceConvention : ComponentConvention<InterfaceComponent, Type>
    {
        public override IEnumerable<Type> Filter(List<Type> components)
        {
            return components.Where(x => x.IsInterface);
        }
    }
}