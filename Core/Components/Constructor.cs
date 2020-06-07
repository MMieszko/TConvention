using System;
using System.Linq;
using System.Reflection;
using Core.Modifiers;

namespace Core.Components
{
    public class Constructor : Component<ConstructorInfo, ConstructorModifier>
    {
        public ParameterInfo[] Parameters => MemberInfo.GetParameters();
        public bool IsParameterless => !this.Parameters.Any();

        public Constructor(ConstructorInfo memberInfo) : base(memberInfo)
        {

        }

        public static implicit operator Constructor(ConstructorInfo info) => new Constructor(info);
        
        protected override bool Is(Enum @enum)
        {
            switch (@enum)
            {
                case ConstructorModifier.Internal:
                    return this.MemberInfo.IsFamily;
                case ConstructorModifier.Private:
                    return this.MemberInfo.IsPrivate;
                case ConstructorModifier.Protected:
                    return this.MemberInfo.IsFamily;
                case ConstructorModifier.Public:
                    return this.MemberInfo.IsPublic;
                case ConstructorModifier.Static:
                    return this.MemberInfo.IsStatic;
                default:
                    //TODO
                    throw new Exception();
            }
        }
    }
}