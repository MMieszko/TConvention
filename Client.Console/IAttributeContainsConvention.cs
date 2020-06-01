using System;
using Client.Console.Asserts;

namespace Client.Console
{
    public interface IAttributeContainsConvention<out TConventionBuilder>
        where TConventionBuilder : IAssert
    {
        TConventionBuilder HasAttribute<T>() where T : Attribute;
        TConventionBuilder HasAttribute<T1, T2>() where T1 : Attribute where T2 : Attribute;
        TConventionBuilder HasAttribute<T1, T2, T3>() where T1 : Attribute where T2 : Attribute where T3 : Attribute;
        TConventionBuilder HasAttribute<T1, T2, T3, T4>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute;
        TConventionBuilder HasAttribute<T1, T2, T3, T4, T5>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute where T5 : Attribute;
        TConventionBuilder HasAttribute<T1, T2, T3, T4, T5, T6>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute where T5 : Attribute where T6 : Attribute;
        TConventionBuilder HasAttribute<T1, T2, T3, T4, T5, T6, T7>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute where T5 : Attribute where T6 : Attribute where T7 : Attribute;
        TConventionBuilder HasAttribute<T1, T2, T3, T4, T5, T6, T7, T8>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute where T5 : Attribute where T6 : Attribute where T7 : Attribute where T8 : Attribute;
    }


}