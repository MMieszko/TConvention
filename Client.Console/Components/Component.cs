using System;
using System.Reflection;

namespace Client.Console.Components
{
    public class Component<T> : IComponent
        where T : MemberInfo
    {
        protected readonly T MemberInfo;

        public Component(T memberInfo)
        {
            MemberInfo = memberInfo;
        }

        public bool HasAttribute<TAttribute>()
            where TAttribute : Attribute
        {
            return MemberInfo.GetCustomAttribute<TAttribute>() != null;
        }
    }

    public interface IComponent
    {

    }
}