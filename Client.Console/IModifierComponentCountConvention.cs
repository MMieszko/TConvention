using System;
using Client.Console.Asserts;

namespace Client.Console
{
    public interface IModifierComponentCountConvention<in TModifierType, out TConventionBuilder>
        where TConventionBuilder : IAssert
        where TModifierType : Enum
    {
        TConventionBuilder HasMaximum(int count);
        TConventionBuilder HasMaximum(TModifierType type, int count);
        TConventionBuilder HasMinimum(TModifierType type, int count);
    }
}