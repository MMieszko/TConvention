using System;
using System.Linq;
using Core.Components;
using Core.Filters.Fields;
using Core.Filters.Methods;
using Core.Filters.Properties;
using Core.Modifiers;

namespace Core.Filters.Classes
{
    public class ClassFilter : Filter<Class, ClassModifier>, IClassFilter
    {
        public ClassFilter(Class[] classes)
            : base(classes)
        {

        }

        public IMethodsFilter Methods => new MethodFilter(Components.SelectMany(x => x.GetMethods()).ToArray());
        public IFieldFilter Fields => new FieldFilter(Components.SelectMany(x => x.GetFields()).ToArray());
        public IPropertyFilter Properties => new PropertyFilter(Components.SelectMany(x => x.GetProperties()).ToArray());

        public IClassFilter Concrete<TClass>()
            where TClass : class
        {
            return new ClassFilter(Components.Where(x => x.MemberInfo == typeof(TClass)).ToArray());
        }

        public IClassFilter Inherit<TClass>()
            where TClass : class
        {
            return new ClassFilter(Components.Where(x => x.Inherit<TClass>()).ToArray());
        }

        public IClassFilter Implements<TInterface>() where TInterface : class
        {
            return new ClassFilter(Components.Where(x => x.Implements<TInterface>()).ToArray());
        }

        public IClassFilter WithAttribute<TAttribute>()
            where TAttribute : Attribute
        {
            return (ClassFilter)base.FilterAttributes<TAttribute>();
        }

        public IClassFilter StartWith(string name)
        {
            return this.Named(x => x.StartsWith(name));
        }

        public IClassFilter EndWith(string name)
        {
            return this.Named(x => x.EndsWith(name));
        }

        public IClassFilter Contain(string name)
        {
            return this.Named(x => x.Contains(name));
        }

        public IClassFilter Named(Predicate<string> predicate)
        {
            return new ClassFilter(Components.Where(x => predicate(x.MemberInfo.Name)).ToArray());
        }

        public IClassFilter Public()
        {
            return new ClassFilter(Components.Where(x => x.Is(ClassModifier.Public)).ToArray());
        }

        public IClassFilter Internal()
        {
            return new ClassFilter(Components.Where(x => x.Is(ClassModifier.Internal)).ToArray());
        }

        public IClassFilter Sealed()
        {
            return new ClassFilter(Components.Where(x => x.Is(ClassModifier.Sealed)).ToArray());
        }

        public IClassFilter Abstract()
        {
            return new ClassFilter(Components.Where(x => x.Is(ClassModifier.Abstract)).ToArray());
        }

        public IClassFilter Partial()
        {
            return new ClassFilter(Components.Where(x => x.Is(ClassModifier.Partial)).ToArray());
        }

        public IClassFilter Ignore<T>()
         where T : class
        {
            return this.Ignore(typeof(T));
        }

        public IClassFilter Ignore<T1, T2>()
            where T1 : class
            where T2 : class
        {
            return this.Ignore(typeof(T1), typeof(T2));
        }

        public IClassFilter Ignore<T1, T2, T3>()
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return this.Ignore(typeof(T1), typeof(T2), typeof(T3));
        }

        public IClassFilter Ignore<T1, T2, T3, T4>()
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return this.Ignore(typeof(T1), typeof(T2), typeof(T3), typeof(T4));
        }

        public IClassFilter Ignore<T1, T2, T3, T4, T5>()
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class

        {
            return this.Ignore(typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5));
        }

        public IClassFilter Ignore<T1, T2, T3, T4, T5, T6>()
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return this.Ignore(typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6));
        }

        private IClassFilter Ignore(params Type[] types)
        {
            return new ClassFilter(Components.Where(x => !types.Contains(x.MemberInfo)).ToArray());
        }
    }
}