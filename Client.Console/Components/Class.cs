using System;
using System.Reflection;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Components
{
    public class Class : Component<Type>
    {
        public Method[] Methods { get; }
        public Property[] Properties { get; }
        public Constructor[] Constructors { get; }

        public Class(Type memberInfo)
            : base(memberInfo)
        {
        }

        public static implicit operator Class(Type info) => new Class(info);
        public static explicit operator Type(Class info) => info.MemberInfo;
        
        public bool Inherit<T>()
            where T : class
        {
            return this.Inherit(typeof(T));
        }

        public bool Inherit(Type type)
        {
            return this.MemberInfo.IsAssignableFrom(type);
        }

        public bool Implements<T>()
            where T : class
        {
            return this.Implements(typeof(T));
        }

        public bool Implements(Type type)
        {
            return this.MemberInfo.IsAssignableFrom(type);
        }

        public bool Is(ClassModifier modifier)
        {
            switch (modifier)
            {
                case ClassModifier.Abstract:
                    return this.MemberInfo.IsAbstract;
                case ClassModifier.Internal:
                    return this.MemberInfo.IsVisible;
                case ClassModifier.Partial:
                    //TODO:
                    return false;
                case ClassModifier.Sealed:
                    return this.MemberInfo.IsSealed;
                case ClassModifier.Public:
                    return this.MemberInfo.IsPublic;
                default:
                    return false;

            }
        }
    }
}