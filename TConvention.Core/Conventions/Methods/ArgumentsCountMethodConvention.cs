using System;
using System.Reflection;

namespace TConvention.Core.Conventions.Methods
{
    public class ArgumentsCountMethodConvention : MethodConvention
    {
        private readonly Predicate<int> _predicate;

        public ArgumentsCountMethodConvention(Predicate<int> predicate)
        {
            _predicate = predicate;
        }

        public override bool IsValid(MethodInfo component)
        {
            throw new System.NotImplementedException();
        }
    }
}