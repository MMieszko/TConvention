using System;
using System.Reflection;

namespace TConvention.Core.Conventions.Methods
{
    public class NameMethodConvention : MethodConvention
    {

        private readonly Predicate<string> _func;

        public NameMethodConvention(Predicate<string> func)
        {
            _func = func;
        }

        public override bool IsValid(MethodInfo component)
        {
            throw new System.NotImplementedException();
        }
    }
}