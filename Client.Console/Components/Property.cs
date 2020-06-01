using System;
using System.Reflection;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Components
{
    public class Property : Component<PropertyInfo>
    {
        private readonly MethodInfo _method;
        private readonly MethodInfo _setMethod;
        private readonly MethodInfo _getMethod;

        public Type Type => _method.ReturnType;
        public bool IsInternal => _method.IsFamily;
        public bool IsPrivate => _method.IsPrivate;
        public bool IsStatic => _method.IsStatic;
        public bool IsPublic => _method.IsPublic;

        //TODO:
        public bool IsProtected => _method.IsPublic;
        public bool IsSetterPublic => _setMethod.IsPublic;
        public bool IsGetterPublic => _getMethod.IsPublic;
        public bool IsSetterProtected => true; // TODO:
        public bool IsGetterSetterProtected => true; // TODO:
        public bool IsSetterPrivate => _setMethod.IsPrivate;
        public bool IsGetterPrivate => _getMethod.IsPrivate;
        public bool IsSetterInternal => _setMethod.IsFamily;
        public bool IsGetterInternal => _getMethod.IsFamily;
        public bool IsAbstract => _method.IsAbstract;

        public Property(PropertyInfo memberInfo) : base(memberInfo)
        {
            _setMethod = memberInfo.GetSetMethod();
            _getMethod = memberInfo.GetGetMethod();
            _method = memberInfo.GetMethod;
        }

        public static implicit operator Property(PropertyInfo info) => new Property(info);

        public bool HasModifier(PropertyModifier modifier)
        {
            switch (modifier)
            {
                case PropertyModifier.Abstract:
                    return this.IsAbstract;
                case PropertyModifier.Internal:
                    return this.IsInternal;
                case PropertyModifier.Private:
                    return this.IsPrivate;
                case PropertyModifier.Protected:
                    return this.IsProtected;
                case PropertyModifier.Public:
                    return this.IsPublic;
                case PropertyModifier.Static:
                    return this.IsStatic;
                default:
                    //TODO
                    throw new Exception();
            }
        }
    }
}