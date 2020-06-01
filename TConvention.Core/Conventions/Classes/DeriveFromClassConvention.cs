using System;

namespace TConvention.Core.Conventions.Classes
{
    public class DeriveFromClassConvention<TBaseType> : ClassConvention
        where TBaseType : class
    {
        public override bool IsValid(Type component)
        {
            throw new NotImplementedException();
        }
    }
}