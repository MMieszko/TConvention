using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Components
{
    public class Method : Component<MethodInfo>
    {
        public Method(MethodInfo methodInfo)
            : base(methodInfo)
        {
        }

        public static implicit operator Method(MethodInfo info) => new Method(info);

        public Type ReturnType => MemberInfo.ReturnType;
        public bool IsStatic => MemberInfo.IsStatic;
        public bool IsPublic => MemberInfo.IsPublic;
        public bool IsProtected => true; // TODO:
        public bool IsPrivate => MemberInfo.IsPrivate;
        public bool IsInternal => MemberInfo.IsFamily;
        public bool IsAbstract => MemberInfo.IsAbstract;
        public bool IsAsync => this.HasAttribute<AsyncStateMachineAttribute>();
        //TODO:
        public bool IsVoid => MemberInfo.ReturnType.Name == "Void";

        public bool HasModifier(MethodModifier modifier)
        {
            switch (modifier)
            {
                case MethodModifier.Abstract:
                    return this.IsAbstract;
                case MethodModifier.Async:
                    return this.IsAsync;
                case MethodModifier.Internal:
                    return this.IsInternal;
                case MethodModifier.Private:
                    return this.IsPrivate;
                case MethodModifier.Protected:
                    return this.IsProtected;
                case MethodModifier.Public:
                    return this.IsPublic;
                case MethodModifier.Static:
                    return this.IsStatic;
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