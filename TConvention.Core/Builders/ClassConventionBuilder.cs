using System;

namespace TConvention.Core.Builders
{
    public class ClassConventionBuilder : IConventionBuilder
    {
        /// <summary>
        /// Determine if class name is named with CamelCase convention
        /// </summary>
        /// <returns></returns>
        public ClassConventionBuilder CamelCase()
        {

        }

        /// <summary>
        /// Determine if class name start with given value
        /// </summary>
        /// <param name="value">String to check</param>
        /// <returns></returns>
        public ClassConventionBuilder StartsWith(string value)
        {

        }

        /// <summary>
        /// Determine if class name ends with given value
        /// </summary>
        /// <param name="value">String to check</param>
        /// <returns></returns>
        public ClassConventionBuilder EndsWith(string value)
        {

        }

        /// <summary>
        /// Determine if class name contains with given value
        /// </summary>
        /// <param name="value">String to check</param>
        /// <returns></returns>
        public ClassConventionBuilder Contains(string value)
        {

        }

        /// <summary>
        /// Determine if class name match given predicate
        /// </summary>
        /// <param name="predicate">Filter function which takes name as parameter</param>
        /// <returns></returns>
        public ClassConventionBuilder Contains(Predicate<string> predicate)
        {

        }

        /// <summary>
        /// Determine if class contains given attribute
        /// </summary>
        /// <typeparam name="TAttribute">Type of <see cref="Attribute"/></typeparam>
        /// <returns></returns>
        public ClassConventionBuilder HasAttribute<TAttribute>()
            where TAttribute : Attribute
        {

        }

        public ClassConventionBuilder Implements<TInterface>()
            where TInterface : class
        {

        }

        public ClassConventionBuilder Sealed()
        {

        }

        public ClassConventionBuilder Public()
        {

        }

        public ClassConventionBuilder Internal()
        {

        }

        public ClassConventionBuilder Generic()
        {

        }

        public ClassConventionBuilder Generic<T>()
        {

        }

        public ClassConventionBuilder HasMaximumPublicMethodCount()
        {

        }

        public ClassConventionBuilder HasMinimumPublicMethodCount()
        {

        }

        public ClassConventionBuilder HasMaximumPrivateMethodCount()
        {

        }

        public ClassConventionBuilder HasMinimumPrivateMethodCount()
        {

        }

        public ClassConventionBuilder HasMaximumStaticMethodCount()
        {

        }

        public ClassConventionBuilder HasMinimumStaticMethodCount()
        {

        }

        public ClassConventionBuilder HasParameterlessConstructor()
        {

        }

        public ClassConventionBuilder HasNotParameterlessConstructor()
        {

        }

        public ClassConventionBuilder HasMaximumConsturctorParametersCount()
        {

        }

        public ClassConventionBuilder HasMinimumConsturctorParametersCount()
        {

        }
    }
}