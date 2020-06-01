using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Client.Console.Asserts.Constructors;
using Client.Console.Asserts.Fields;
using Client.Console.Asserts.Methods;
using Client.Console.Asserts.Properties;
using Client.Console.Components;
using Client.Console.Extensions;
using Client.Console.Filters.Classes;
using Client.Console.Filters.Constructors;
using Client.Console.Filters.Fields;
using Client.Console.Filters.Methods;
using Client.Console.Filters.Properties;

namespace Client.Console.Asserts.Classes
{
    public class ClassAssert : Assert<Class>, IClassAssert
    {
        public ClassAssert(Class[] components)
            : base(components)
        {

        }

        public IClassAssert HasAttribute<T>() where T : Attribute
        {
            throw new NotImplementedException();
        }

        public IClassAssert HasAttribute<T1, T2>() where T1 : Attribute where T2 : Attribute
        {
            throw new NotImplementedException();
        }

        public IClassAssert HasAttribute<T1, T2, T3>() where T1 : Attribute where T2 : Attribute where T3 : Attribute
        {
            throw new NotImplementedException();
        }

        public IClassAssert HasAttribute<T1, T2, T3, T4>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute
        {
            throw new NotImplementedException();
        }

        public IClassAssert HasAttribute<T1, T2, T3, T4, T5>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute where T5 : Attribute
        {
            throw new NotImplementedException();
        }

        public IClassAssert HasAttribute<T1, T2, T3, T4, T5, T6>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute where T5 : Attribute where T6 : Attribute
        {
            throw new NotImplementedException();
        }

        public IClassAssert HasAttribute<T1, T2, T3, T4, T5, T6, T7>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute where T5 : Attribute where T6 : Attribute where T7 : Attribute
        {
            throw new NotImplementedException();
        }

        public IClassAssert HasAttribute<T1, T2, T3, T4, T5, T6, T7, T8>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute where T5 : Attribute where T6 : Attribute where T7 : Attribute where T8 : Attribute
        {
            throw new NotImplementedException();
        }
    }
}