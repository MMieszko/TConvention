using System;

namespace Core.Modifiers
{
    [Flags]
    public enum PropertyModifier
    {
        PublicGet = 1,
        PublicSet = 2,
        InternalGet = 4,
        InternalSet = 8,
        ProtectedGet = 16,
        ProtectedSet = 32,
        PrivateGet = 64,
        PrivateSet = 128,
        Abstract = 256,
        Readonly = 512,
        Static = 1024
    }
}