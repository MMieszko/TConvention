using System;
using System.Linq;
using System.Reflection;
using Core.Extensions;

namespace Core.Components
{
    public abstract class Component<TMemberInfo, TModifier> : IComponent
        where TMemberInfo : MemberInfo
        where TModifier : Enum
    {
        public readonly TMemberInfo MemberInfo;

        protected Component(TMemberInfo memberInfo)
        {
            MemberInfo = memberInfo;
        }

        protected abstract bool Is(Enum @enum);

        public bool Is(TModifier modifier)
        {
            return modifier.GetFlags().All(this.Is);
        }

        public bool HasAttribute<TAttribute>()
            where TAttribute : Attribute
        {
            return MemberInfo.GetCustomAttribute<TAttribute>() != null;
        }

        public bool HasAttribute(Type t)
        {
            return MemberInfo.GetCustomAttribute(t) != null;
        }
    }

    public interface IComponent
    {
        bool HasAttribute<TAttribute>()
            where TAttribute : Attribute;
    }
}