using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Core.Modifiers;

namespace Core.Components
{
    public class Method : Component<MethodInfo, MethodModifier>
    {
        public bool IsVoid => MemberInfo.ReturnType.Name == "Void";
        public Type ReturnType => this.MemberInfo.ReturnType;

        public Method(MethodInfo methodInfo)
            : base(methodInfo)
        {
        }

        public static implicit operator Method(MethodInfo info) => new Method(info);

        public bool ReturnsAsync()
        {
            return typeof(Task).IsAssignableFrom(ReturnType);
        }

        public bool ReturnsAsync<T>()
        {
            if (!this.ReturnType.IsGenericType)
            {
                return false;
            }
            var genericType = this.ReturnType.GenericTypeArguments[0];

            if (!typeof(T).IsAssignableFrom(genericType))
            {
                return false;
            }

            return typeof(Task).IsAssignableFrom(ReturnType.BaseType);
        }

        public bool Returns<T>()
        {
            return typeof(T).IsAssignableFrom(ReturnType);
        }

        protected override bool Is(Enum @enum)
        {
            switch (@enum)
            {
                case MethodModifier.Abstract:
                    return this.MemberInfo.IsAbstract;
                case MethodModifier.Async:
                    return this.HasAttribute<AsyncStateMachineAttribute>();
                case MethodModifier.Internal:
                    return this.MemberInfo.IsFamily; ;
                case MethodModifier.Private:
                    return this.MemberInfo.IsPrivate;
                case MethodModifier.Protected:
                    return this.MemberInfo.IsFamily;
                case MethodModifier.Public:
                    return this.MemberInfo.IsPublic;
                case MethodModifier.Static:
                    return this.MemberInfo.IsStatic;
                default:
                    //TODO
                    throw new Exception();
            }
        }

        public override string ToString()
        {
            return $"<{MemberInfo.ReturnType.Name}>   {MemberInfo.Name}";
        }
    }
}