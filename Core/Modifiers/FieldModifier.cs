using System;

namespace Core.Modifiers
{
    [Flags]
    public enum FieldModifier
    {
        Public = 1,
        Internal = 2,
        Protected = 4,
        Private = 8,
        Readonly = 16,
        Const = 32,
        Static = 64
    }
}