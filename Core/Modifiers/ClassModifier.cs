using System;

namespace Core.Modifiers
{
    [Flags]
    public enum ClassModifier
    {
        Public = 1,
        Internal = 2,
        Sealed = 4,
        Partial = 8,
        Abstract = 16
    }
}