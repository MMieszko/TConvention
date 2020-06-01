using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Client.Console.Asserts.Classes;
using Client.Console.Asserts.Constructors;
using Client.Console.Asserts.Fields;
using Client.Console.Asserts.Methods;
using Client.Console.Asserts.Properties;
using Client.Console.Extensions;
using Client.Console.Filters.Classes;
using Client.Console.Filters.Constructors;
using Client.Console.Filters.Fields;
using Client.Console.Filters.Methods;
using Client.Console.Filters.Modifiers;
using Client.Console.Filters.Properties;

namespace Client.Console.Asserts
{
    public class ConventionAssert
    {
        private readonly ICollection<Type> _types;

        protected IDictionary<IMethodsFilter, Action<IMethodAssert>> MethodsAsserts;
        protected IDictionary<IFieldFilter, Action<IFieldAssert>> FieldsAsserts;
        protected IDictionary<IPropertyFilter, Action<IPropertyAssert>> PropertiesAsserts;
        protected IDictionary<IConstructorFilter, Action<IConstructorAssert>> ConstructorsAssert;
        protected IDictionary<IClassFilter, Action<IClassAssert>> ClassAsserts;

        private ConventionAssert(Assembly assembly)
        {
            _types = assembly.GetTypes().ToList();

            MethodsAsserts = new Dictionary<IMethodsFilter, Action<IMethodAssert>>();
            ClassAsserts = new Dictionary<IClassFilter, Action<IClassAssert>>();
        }

        public void Assert()
        {
            foreach (var methodAssert in MethodsAsserts)
            {
                var filter = methodAssert.Key;

                try
                {
                    methodAssert.Value.Invoke(new MethodAssert(filter.Methods));
                }
                catch (ConventionAssertException e)
                {

                }
                catch (Exception ex)
                {

                }
            }
        }

        public static ConventionAssert ForAssembly(Assembly assembly)
        {
            return new ConventionAssert(assembly);
        }

        public static ConventionAssert ForCurrentAssembly()
        {
            throw new NotImplementedException();
        }

        public ConventionAssert Ignore<T>()
            where T : class
        {
            _types.Remove(typeof(T));

            return this;
        }

        public ConventionAssert Classes(Action<IClassAssert> assert)
        {
            ClassAsserts.Add(new ClassFilter(_types.GetClasses()), assert);

            return this;
        }

        public ConventionAssert Classes(Func<IClassFilter, IClassFilter> filter, Action<IClassAssert> assert)
        {

            ClassAsserts.Add(filter(new ClassFilter(_types.GetClasses())), assert);

            return this;
        }

        public ConventionAssert Methods(Func<IMethodsFilter, IMethodsFilter> filter, Action<IMethodAssert> assert)
        {
            MethodsAsserts.Add(filter(new MethodFilter(_types.GetMethods())), assert);

            return this;
        }

        public ConventionAssert Methods(Action<IMethodAssert> assert)
        {
            MethodsAsserts.Add(new MethodFilter(_types.GetMethods()), assert);

            return this;
        }

        public ConventionAssert Fields(Func<IFieldFilter, IFieldFilter> filter, Action<IFieldAssert> assert)
        {
            FieldsAsserts.Add(filter(new FieldFilter(_types.GetFields())), assert);

            return this;
        }

        public ConventionAssert Fields(Action<IFieldAssert> assert)
        {
            FieldsAsserts.Add(new FieldFilter(_types.GetFields()), assert);

            return this;
        }

        public ConventionAssert Properties(Func<IPropertyFilter, IPropertyFilter> filter, Action<IPropertyAssert> assert)
        {
            return this;
        }

        public ConventionAssert Properties(Action<IPropertyAssert> assert)
        {
            return this;
        }

        public ConventionAssert Constructors(Func<IConstructorFilter, IConstructorFilter> filter, Action<IConstructorAssert> assert)
        {
            return this;
        }

        public ConventionAssert Constructors(Action<IPropertyAssert> assert)
        {
            return this;
        }
    }
}