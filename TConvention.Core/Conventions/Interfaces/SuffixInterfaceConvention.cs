using System;

namespace TConvention.Core.Conventions.Interfaces
{
    public class SuffixInterfaceConvention : InterfaceConvention
    {
        public override bool IsValid(Type component)
        {
            return component.Name.StartsWith("I");
        }
    }
}