using System;

namespace Core.Modifiers
{
    [Flags]
    public enum MethodModifier
    {
        Public = 1,
        Internal = 2,
        Protected = 4,
        Private = 8,
        Static = 16,
        Async = 32,
        Abstract = 64,
        Virtual = 128
    }
}