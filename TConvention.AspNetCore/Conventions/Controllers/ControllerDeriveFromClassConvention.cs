using System;
using System.Collections.Generic;
using TConvention.Core.Conventions.Classes;

namespace TConvention.AspNetCore.Conventions
{
    public class ControllerDeriveFromClassConvention<TBaseType> : DeriveFromClassConvention<TBaseType>
    {
        public override IEnumerable<Type> Filter(List<Type> components)
        {
            return base.Filter(components);
        }
    }
}