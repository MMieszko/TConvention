using System;
using Core.Components;
using Core.Filters.Constructors;
using Core.Filters.Fields;
using Core.Filters.Methods;
using Core.Filters.Properties;

namespace Core.Filters.Classes
{
    public interface IClassFilter : IFilter<Class>
    {
        IMethodsFilter Methods { get; }
        IFieldFilter Fields { get; }
        IPropertyFilter Properties { get; }
        IConstructorFilter Constructors { get; }
        IClassFilter Concrete<TClass>() where TClass : class;
        IClassFilter Inherit<TClass>(bool includeGivenType = false) where TClass : class;
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
        IClassFilter Ignore<T>() where T : class;
        IClassFilter Ignore<T1, T2>() where T1 : class
            where T2 : class;
        IClassFilter Ignore<T1, T2, T3>() where T1 : class
            where T2 : class
            where T3 : class;
        IClassFilter Ignore<T1, T2, T3, T4>() where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class;
        IClassFilter Ignore<T1, T2, T3, T4, T5>() where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class;
        IClassFilter Ignore<T1, T2, T3, T4, T5, T6>() where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class;
    }
}