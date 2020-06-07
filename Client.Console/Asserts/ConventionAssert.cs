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

        private ConventionAssert(Assembly assembly)
        {
            _types = assembly.GetTypes().ToList();

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

        public IClassFilter Classes()
        {
            return null;
        }

        public ConventionAssert Classes(Func<IClassFilter, IClassFilter> filter)
        {
            return this;
        }

        public ConventionAssert Methods(Func<IMethodsFilter, IMethodsFilter> filter)
        {
            return this;
        }
    

        public ConventionAssert Fields(Func<IFieldFilter, IFieldFilter> filter)
        {
            //FieldsAsserts.Add(filter(new FieldFilter(_types.GetFields())), assert);

            return this;
        }

        public ConventionAssert Properties(Func<IPropertyFilter, IPropertyFilter> filter)
        {
            return this;
        }

 

        public ConventionAssert Constructors(Func<IConstructorFilter, IConstructorFilter> filter)
        {
            return this;
        }


    }
}