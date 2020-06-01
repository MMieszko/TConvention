using System;
using System.Reflection;
using Client.Console.Components;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Asserts.Fields
{
    public class FieldAssert : Assert<Field>, IFieldAssert
    {
        public FieldAssert(Field[] components)
            : base(components)
        {
        }

        public IFieldAssert HasAttribute<T>() where T : Attribute
        {
            throw new NotImplementedException();
        }

        public IFieldAssert HasAttribute<T1, T2>() where T1 : Attribute where T2 : Attribute
        {
            throw new NotImplementedException();
        }

        public IFieldAssert HasAttribute<T1, T2, T3>() where T1 : Attribute where T2 : Attribute where T3 : Attribute
        {
            throw new NotImplementedException();
        }

        public IFieldAssert HasAttribute<T1, T2, T3, T4>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute
        {
            throw new NotImplementedException();
        }

        public IFieldAssert HasAttribute<T1, T2, T3, T4, T5>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute where T5 : Attribute
        {
            throw new NotImplementedException();
        }

        public IFieldAssert HasAttribute<T1, T2, T3, T4, T5, T6>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute where T5 : Attribute where T6 : Attribute
        {
            throw new NotImplementedException();
        }

        public IFieldAssert HasAttribute<T1, T2, T3, T4, T5, T6, T7>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute where T5 : Attribute where T6 : Attribute where T7 : Attribute
        {
            throw new NotImplementedException();
        }

        public IFieldAssert HasAttribute<T1, T2, T3, T4, T5, T6, T7, T8>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute where T5 : Attribute where T6 : Attribute where T7 : Attribute where T8 : Attribute
        {
            throw new NotImplementedException();
        }

        public IFieldAssert HasMaximum(int count)
        {
            throw new NotImplementedException();
        }

        public IFieldAssert HasMaximum(FieldModifier type, int count)
        {
            throw new NotImplementedException();
        }

        public IFieldAssert HasMinimum(FieldModifier type, int count)
        {
            throw new NotImplementedException();
        }
    }
}