using System;
using System.Reflection;
using Core.Modifiers;

namespace Core.Components
{
    public class Field : Component<FieldInfo, FieldModifier>
    {
        public Type Type => this.MemberInfo.FieldType;

        public Field(FieldInfo fieldInfo)
            : base(fieldInfo)
        {

        }

        public static implicit operator Field(FieldInfo info) => new Field(info);
        
        protected override bool Is(Enum @enum)
        {
            switch (@enum)
            {
                case FieldModifier.Internal:
                    return this.MemberInfo.IsFamily;
                case FieldModifier.Private:
                    return this.MemberInfo.IsPrivate;
                case FieldModifier.Protected:
                    return this.MemberInfo.IsFamily;
                case FieldModifier.Public:
                    return this.MemberInfo.IsPublic;
                case FieldModifier.Readonly:
                    return this.MemberInfo.IsInitOnly;
                case FieldModifier.Const:
                    return this.MemberInfo.IsLiteral;
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