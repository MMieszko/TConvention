using System;
using System.Reflection;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Components
{
    public class Field : Component<FieldInfo>
    {
        public bool IsStatic => MemberInfo.IsStatic;
        public bool IsPublic => MemberInfo.IsPublic;
        public bool IsProtected => true; // TODO:
        public bool IsPrivate => MemberInfo.IsPrivate;
        public bool IsInternal => MemberInfo.IsFamily;

        public Field(FieldInfo fieldInfo)
            : base(fieldInfo)
        {

        }

        public static implicit operator Field(FieldInfo info) => new Field(info);

        public bool HasModifier(FieldModifier modifier)
        {
            switch (modifier)
            {
                case FieldModifier.Internal:
                    return this.IsInternal;
                case FieldModifier.Private:
                    return this.IsPrivate;
                case FieldModifier.Protected:
                    return this.IsProtected;
                case FieldModifier.Public:
                    return this.IsPublic;
                default:
                    //TODO
                    throw new Exception();
            }
        }

        public override string ToString()
        {
            return $"<{MemberInfo.FieldType.Name}>   {MemberInfo.Name}";
        }
    }
}