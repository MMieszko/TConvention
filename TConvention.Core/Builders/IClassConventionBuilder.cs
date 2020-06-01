using System;

namespace TConvention.Core.Builders
{
    interface IClassConventionBuilder
    {
        /// <summary>
        /// Determine if class name is named with CamelCase convention
        /// </summary>
        /// <returns></returns>
        ClassConventionBuilder CamelCase();

        /// <summary>
        /// Determine if class name start with given value
        /// </summary>
        /// <param name="value">String to check</param>
        /// <returns></returns>
        ClassConventionBuilder StartsWith(string value);

        /// <summary>
        /// Determine if class name ends with given value
        /// </summary>
        /// <param name="value">String to check</param>
        /// <returns></returns>
        ClassConventionBuilder EndsWith(string value);

        /// <summary>
        /// Determine if class name contains with given value
        /// </summary>
        /// <param name="value">String to check</param>
        /// <returns></returns>
        ClassConventionBuilder Contains(string value);

        /// <summary>
        /// Determine if class name match given predicate
        /// </summary>
        /// <param name="predicate">Filter function which takes name as parameter</param>
        /// <returns></returns>
        ClassConventionBuilder Contains(Predicate<string> predicate);

        /// <summary>
        /// Determine if class contains given attribute
        /// </summary>
        /// <typeparam name="TAttribute">Type of <see cref="Attribute"/></typeparam>
        /// <returns></returns>
        ClassConventionBuilder HasAttribute<TAttribute>() where TAttribute : Attribute;

        ClassConventionBuilder Implements<TInterface>() where TInterface : class;

        ClassConventionBuilder Sealed();

        ClassConventionBuilder Internal();

        ClassConventionBuilder Generic();

        ClassConventionBuilder Generic<T>();

        ClassConventionBuilder HasMaximumMethodCount();

        ClassConventionBuilder HasMinimumMethodCount();
        ClassConventionBuilder HasMaximumPrivateMethodCount();

        ClassConventionBuilder HasMinimumPrivateMethodCount();

        ClassConventionBuilder HasMaximumStaticMethodCount();

        ClassConventionBuilder HasMinimumStaticMethodCount();

        ClassConventionBuilder HasParameterlessConstructor();

        ClassConventionBuilder HasNotParameterlessConstructor();

        ClassConventionBuilder HasMaximumConsturctorParametersCount();

        ClassConventionBuilder HasMinimumConsturctorParametersCount();
    }
}

