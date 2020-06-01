using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Console.Components;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Asserts.Methods
{
    public class MethodAssert : Assert<Method>, IMethodAssert
    {
        public MethodAssert(Method[] components)
            : base(components)
        {
        }

        public IMethodAssert ReturnsAsync(string because = null)
        {
            var result = Components.Where(x => x.IsAsync && x.ReturnType != typeof(Task)).ToArray();

            if (result.Any())
                throw new ConventionAssertException(result, $"Assertion failed with {nameof(IMethodAssert.ReturnsAsync)}. {because}");

            return this;
        }

        public IMethodAssert Returns<TResult>(string because = null)
        {
            var result = Components.Where(x => x.ReturnType != typeof(TResult)).ToList();

            if (result.Any())
            {
                //TODO:
            }

            return this;
        }

        public IMethodAssert ReturnsAsync<TResult>(string because = null)
        {
            var result = Components.Where(x => x.ReturnType != typeof(Task<TResult>)).ToList();

            return this;
        }

        public IMethodAssert HasMaximum(int count)
        {
            throw new NotImplementedException();
        }

        public IMethodAssert HasMaximum(MethodModifier type, int count)
        {
            throw new NotImplementedException();
        }

        public IMethodAssert HasMinimum(MethodModifier type, int count)
        {
            throw new NotImplementedException();
        }

        public IMethodAssert HasMaximumArgumentsCount(int count)
        {
            return this;
        }

        public IMethodAssert HasMinimumArgumentsCount(int count)
        {
            throw new NotImplementedException();
        }

        public IMethodAssert HasAttribute<TAttribute>() where TAttribute : Attribute
        {
            var result = Components.Where(x => x.HasAttribute<TAttribute>()).ToList();

            if (result.Any())
            {
                //TODO:
            }

            return this;
        }

        public IMethodAssert HasAttribute<T1, T2>() where T1 : Attribute where T2 : Attribute
        {
            throw new NotImplementedException();
        }

        public IMethodAssert HasAttribute<T1, T2, T3>() where T1 : Attribute where T2 : Attribute where T3 : Attribute
        {
            throw new NotImplementedException();
        }

        public IMethodAssert HasAttribute<T1, T2, T3, T4>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute
        {
            throw new NotImplementedException();
        }

        public IMethodAssert HasAttribute<T1, T2, T3, T4, T5>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute where T5 : Attribute
        {
            throw new NotImplementedException();
        }

        public IMethodAssert HasAttribute<T1, T2, T3, T4, T5, T6>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute where T5 : Attribute where T6 : Attribute
        {
            throw new NotImplementedException();
        }

        public IMethodAssert HasAttribute<T1, T2, T3, T4, T5, T6, T7>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute where T5 : Attribute where T6 : Attribute where T7 : Attribute
        {
            throw new NotImplementedException();
        }

        public IMethodAssert HasAttribute<T1, T2, T3, T4, T5, T6, T7, T8>() where T1 : Attribute where T2 : Attribute where T3 : Attribute where T4 : Attribute where T5 : Attribute where T6 : Attribute where T7 : Attribute where T8 : Attribute
        {
            throw new NotImplementedException();
        }
    }
}