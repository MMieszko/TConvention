using System;
using System.Reflection;
using Core.Modifiers;

namespace Core.Components
{
    public class Property : Component<PropertyInfo, PropertyModifier>
    {
        private readonly MethodInfo _method;
        private readonly MethodInfo _setMethod;
        private readonly MethodInfo _getMethod;

        public Type ReturnType => this.MemberInfo.PropertyType;

        public Property(PropertyInfo memberInfo) : base(memberInfo)
        {
            _setMethod = memberInfo.GetSetMethod(true);
            _getMethod = memberInfo.GetGetMethod(true);
            _method = memberInfo.GetMethod;
        }

        public static implicit operator Property(PropertyInfo info) => new Property(info);
        protected override bool Is(Enum @enum)
        {
            switch (@enum)
            {
                case PropertyModifier.PublicSet:
                    return this._setMethod?.IsPublic ?? false;
                case PropertyModifier.PublicGet:
                    return this._getMethod.IsPublic;
                case PropertyModifier.InternalSet:
                    return this._setMethod?.IsFamily ?? false;
                case PropertyModifier.InternalGet:
                    return this._getMethod.IsFamily;
                case PropertyModifier.ProtectedSet:
                    return this._setMethod?.IsFamily ?? false;
                case PropertyModifier.ProtectedGet:
                    return this._getMethod.IsFamily;
                case PropertyModifier.PrivateSet:
                    return this._setMethod?.IsPrivate ?? false;
                case PropertyModifier.PrivateGet:
                    return this._getMethod.IsPrivate;
                case PropertyModifier.Readonly:
                    return this._setMethod == null;
                case PropertyModifier.Abstract:
                    return this._method.IsAbstract;
                case PropertyModifier.Static:
                    return this._method.IsStatic;
                default:
                    //TODO
                    throw new Exception();
            }
        }
        public override string ToString()
        {
            return $"<{ReturnType.Name}>   {_method.Name}";
        }
    }
}