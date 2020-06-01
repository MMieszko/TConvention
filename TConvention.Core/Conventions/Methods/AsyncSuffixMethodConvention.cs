using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace TConvention.Core.Conventions.Methods
{
    public class AsyncSuffixMethodConvention : MethodConvention
    {
        public override IEnumerable<MethodInfo> Filter(List<MethodInfo> components)
        {
            foreach (var component in components)
            {
                if (IsAsyncMethod(component))
                {
                    yield return component;
                }
            }
        }

        public override bool IsValid(MethodInfo method)
        {
            return !IsAsyncMethod(method) || method.Name.EndsWith("Async");
        }

        private static bool IsAsyncMethod(MethodBase method)
        {
            var asyncAttr = (AsyncStateMachineAttribute)method.GetCustomAttribute(typeof(AsyncStateMachineAttribute));

            return asyncAttr != null;
        }
    }
}