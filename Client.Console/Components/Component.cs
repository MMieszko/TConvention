using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Client.Console.Components
{
    public class Component<T> : IComponent
        where T : MemberInfo
    {
        public readonly T MemberInfo;

        public Component(T memberInfo)
        {
            MemberInfo = memberInfo;
        }

        public bool HasAttribute<TAttribute>()
            where TAttribute : Attribute
        {
            return MemberInfo.GetCustomAttribute<TAttribute>() != null;
        }

        public bool HasAttributes(List<Type> attributes)
        {
            return this.MemberInfo.GetCustomAttributes().Any(x => x.GetType() == typeof(T));
        }
    }

    public interface IComponent
    {
        bool HasAttribute<TAttribute>()
            where TAttribute : Attribute;

        bool HasAttributes(List<Type> attributes);
    }
}