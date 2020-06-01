using System;

namespace TConvention.Core.Conventions.Classes
{
    public class AttributeClassConvention<TAttribute> : ClassConvention
    {
        public override bool IsValid(Type component)
        {
            throw new NotImplementedException();
        }
    }
}