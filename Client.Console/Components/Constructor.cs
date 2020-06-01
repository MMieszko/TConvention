using System;
using System.Reflection;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Components
{
    public class Constructor : Component<ConstructorInfo>
    {
        public bool IsStatic => MemberInfo.IsStatic;
        public bool IsPublic => MemberInfo.IsPublic;
        public bool IsProtected => true; // TODO:
        public bool IsPrivate => MemberInfo.IsPrivate;
        public bool IsInternal => MemberInfo.IsFamily;

        public ParameterInfo[] Parameters => MemberInfo.GetParameters();

        public static implicit operator Constructor(ConstructorInfo info) => new Constructor(info);

        public Constructor(ConstructorInfo memberInfo) : base(memberInfo)
        {

        }

        public bool HasModifier(ConstructorModifier modifier)
        {
            switch (modifier)
            {
                case ConstructorModifier.Internal:
                    return this.IsInternal;
                case ConstructorModifier.Private:
                    return this.IsPrivate;
                case ConstructorModifier.Protected:
                    return this.IsProtected;
                case ConstructorModifier.Public:
                    return this.IsPublic;
                case ConstructorModifier.Static:
                    return this.IsStatic;
                default:
                    //TODO
                    throw new Exception();
            }
        }
    }
}