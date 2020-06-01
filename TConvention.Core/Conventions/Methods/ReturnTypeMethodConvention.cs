using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace TConvention.Core.Conventions.Methods
{
    public class ReturnTypeMethodConvention<TReturnType> : MethodConvention
    {
        public override bool IsValid(MethodInfo component)
        {
            return component.ReturnType == typeof(TReturnType) || component.ReturnType == typeof(Task<TReturnType>);
        }
    }
}