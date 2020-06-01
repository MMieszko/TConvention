using System;
using Client.Console.Asserts.Classes;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Filters.Classes
{
    public interface IClassFilter : IFilter
    {
        IConcreteClassAssert<TClass> Concrete<TClass>() where TClass : class;
        IClassFilter Derives<TClass>() where TClass : class;
        IClassFilter Implements<TInterface>() where TInterface : class;
        IClassFilter WithModifier(ClassModifier modifier);
        IClassFilter WithAttribute<TAttribute>(ClassModifier modifier) where TAttribute : Attribute;
        IClassFilter WithEnds(string suffix);

        IClassFilter Ignore<T>();
        IClassFilter Ignore<T1, T2>();
        IClassFilter Ignore<T1, T2, T3>();
        IClassFilter Ignore<T1, T2, T3, T4, T5>();
        IClassFilter Ignore<T1, T2, T3, T4, T5, T6>();
        IClassFilter Ignore<T1, T2, T3, T4, T5, T6, T7>();
        IClassFilter Ignore<T1, T2, T3, T4, T5, T6, T7, T8>();
        IClassFilter Ignore<T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        IClassFilter Ignore<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
    }
}