using System;
using Client.Console.Asserts.Classes;
using Client.Console.Components;
using Client.Console.Filters.Constructors;
using Client.Console.Filters.Methods;
using Client.Console.Filters.Modifiers;
using Client.Console.Filters.Properties;

namespace Client.Console.Filters.Classes
{
    public interface IClassFilter : IFilter<Class>
    {
        IClassFilter Concrete<TClass>() where TClass : class;
        IClassFilter Inherit<TClass>() where TClass : class;
        IClassFilter Implements<TInterface>() where TInterface : class;
        IClassFilter WithAttribute<TAttribute>() where TAttribute : Attribute;
        IClassFilter Named(Predicate<string> predicate);
        IClassFilter StartWith(string name);
        IClassFilter EndWith(string name);
        IClassFilter Contain(string name);
        IClassFilter Public();
        IClassFilter Internal();
        IClassFilter Sealed();
        IClassFilter Abstract();
        IClassFilter Partial();
        IClassFilter Ignore<T>();
        IClassFilter Ignore<T1, T2>();
        IClassFilter Ignore<T1, T2, T3>();
        IClassFilter Ignore<T1, T2, T3, T4>();
        IClassFilter Ignore<T1, T2, T3, T4, T5>();
        IClassFilter Ignore<T1, T2, T3, T4, T5, T6>();
    }
}