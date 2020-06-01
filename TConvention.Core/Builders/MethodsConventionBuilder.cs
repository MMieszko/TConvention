using System;
using System.Collections.Generic;
using System.Reflection;
using TConvention.Core.Conventions;
using TConvention.Core.Conventions.Methods;

namespace TConvention.Core.Builders
{
    public abstract class MethodsConventionBuilder : IMethodConventionBuilder
    {
        protected List<MethodConvention> Conventions;

        protected MethodsConventionBuilder()
        {
            this.Conventions = new List<MethodConvention>();
        }

        /// <summary>
        /// Determine if method name is named with CamelCase convention
        /// </summary>
        /// <returns></returns>
        public MethodsConventionBuilder CamelCase()
        {
            this.Conventions.Add(new CamelCaseMethodConvention());

            return this;
        }

        /// <summary>
        /// Determine if method name start with given value
        /// </summary>
        /// <param name="value">String to check</param>
        /// <returns></returns>
        public MethodsConventionBuilder StartsWith(string value)
        {
            this.Conventions.Add(new NameMethodConvention(x => x.StartsWith(value)));

            return this;
        }

        /// <summary>
        /// Determine if method name ends with given value
        /// </summary>
        /// <param name="value">String to check</param>
        /// <returns></returns>
        public MethodsConventionBuilder EndsWith(string value)
        {
            this.Conventions.Add(new NameMethodConvention(x => x.EndsWith(value)));

            return this;
        }

        /// <summary>
        /// Determine if method name contains with given value
        /// </summary>
        /// <param name="value">String to check</param>
        /// <returns></returns>
        public MethodsConventionBuilder Contains(string value)
        {
            this.Conventions.Add(new NameMethodConvention(x => x.Contains(value)));

            return this;
        }

        /// <summary>
        /// Determine if method name match given predicate
        /// </summary>
        /// <param name="predicate">Filter function which takes name as parameter</param>
        /// <returns></returns>
        public MethodsConventionBuilder Contains(Predicate<string> predicate)
        {
            this.Conventions.Add(new NameMethodConvention(predicate));

            return this;
        }

        /// <summary>
        /// Determine if method contains given attribute
        /// </summary>
        /// <typeparam name="TAttribute">Type of <see cref="Attribute"/></typeparam>
        /// <returns></returns>
        public MethodsConventionBuilder HasAttribute<TAttribute>()
            where TAttribute : Attribute
        {
            this.Conventions.Add(new AttributeMethodConvention<TAttribute>());

            return this;
        }

        /// <summary>
        /// Determine if method returns given type
        /// </summary>
        /// <typeparam name="TResult">Expected return type of method</typeparam>
        /// <returns></returns>
        public MethodsConventionBuilder Returns<TResult>()
        {
            this.Conventions.Add(new ReturnTypeMethodConvention<TResult>());

            return this;
        }

        /// <summary>
        /// Determine if method contain parameter of given type
        /// </summary>
        /// <typeparam name="T">Type of parameter</typeparam>
        /// <returns></returns>
        public MethodsConventionBuilder HasParameterOfType<T>()
        {
            this.Conventions.Add(new ParameterTypeMethodConvention<T>());

            return this;
        }

        /// <summary>
        /// Determine if method contain parameter of given type
        /// </summary>
        /// <param name="type">Type of parameter</param>
        /// <returns></returns>
        public MethodsConventionBuilder HasParameterOfType(Type type)
        {
            this.Conventions.Add(new ParameterTypeMethodConvention(type));

            return this;
        }

        /// <summary>
        /// Determine if method has no more than given parameters count
        /// </summary>
        /// <param name="value">Expected maximum parameters count</param>
        /// <returns></returns>
        public MethodsConventionBuilder HasMaximumParametersCount(int value)
        {
            if (value < 1)
            {
                //TODO: Throw invalid config 
            }

            this.Conventions.Add(new ArgumentsCountMethodConvention(x => x <= value));

            return this;
        }

        /// <summary>
        /// Determine if method has less or equal than given parameters count
        /// </summary>
        /// <param name="value">Expected minimum parameters count</param>
        /// <returns></returns>
        public MethodsConventionBuilder HasMinimumParametersCount(int value)
        {
            if (value < 1)
            {
                //TODO: Throw invalid config 
            }

            this.Conventions.Add(new ArgumentsCountMethodConvention(x => x >= value));

            return this;
        }

        /// <summary>
        /// Determine if method has given parameters count
        /// </summary>
        /// <param name="value">Expected parameters count</param>
        /// <returns></returns>
        public MethodsConventionBuilder HasMParametersCount(int value)
        {
            if (value < 1)
            {
                //TODO: Throw invalid config 
            }

            this.Conventions.Add(new ArgumentsCountMethodConvention(x => x == value));

            return this;
        }
    }

    public class InsideAssemblyMethodBuilder : MethodsConventionBuilder
    {

    }

    public class InsideClassMethodConventionBuilder<TClass> : MethodsConventionBuilder
        where TClass : class
    {

        public InsideClassMethodConventionBuilder()

        {
        }
    }

    public class InsideClassesDerivedFrom<TClass> : MethodsConventionBuilder
    {
        public InsideClassesDerivedFrom(IConventionRoot conventionRoot)
        {
        }
    }
}