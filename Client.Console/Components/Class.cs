using System;
using System.Reflection;

namespace Client.Console.Components
{
    public class Class : Component<Type>
    {
        public Class(Type memberInfo)
            : base(memberInfo)
        {
        }

        public static implicit operator Class(Type info) => new Class(info);
    }
}