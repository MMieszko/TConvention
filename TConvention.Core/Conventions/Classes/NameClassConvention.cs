using System;

namespace TConvention.Core.Conventions.Classes
{
    public class NameClassConvention : ClassConvention
    {
        private readonly Func<string, bool> _validFunc;

        public NameClassConvention(Func<string, bool> validFunc)
        {
            _validFunc = validFunc;
        }

        public override bool IsValid(Type component)
        {
            return _validFunc(component.Name);
        }
    }
}