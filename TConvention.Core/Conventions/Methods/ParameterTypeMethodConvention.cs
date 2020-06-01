using System;
using System.Reflection;

namespace TConvention.Core.Conventions.Methods
{
    public class ParameterTypeMethodConvention<T> : MethodConvention
    {
        public override bool IsValid(MethodInfo component)
        {
            throw new System.NotImplementedException();
        }
    }

    public class ParameterTypeMethodConvention : MethodConvention
    {
        private readonly Type _type;

        public ParameterTypeMethodConvention(Type type)
        {
            _type = type;
        }


        public override bool IsValid(MethodInfo component)
        {
            throw new System.NotImplementedException();
        }
    }
}