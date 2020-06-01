using System;

namespace TConvention.Core.Builders
{
    interface IMethodConventionBuilder : IConventionBuilder
    {
        /// <summary>
        /// Determine if method name is named with CamelCase convention
        /// </summary>
        /// <returns></returns>
        MethodsConventionBuilder CamelCase();

        /// <summary>
        /// Determine if method name start with given value
        /// </summary>
        /// <param name"value">String to check</param>
        /// <returns></returns>
        MethodsConventionBuilder StartsWith(string value);

        /// <summary>
        /// Determine if method name ends with given value
        /// </summary>
        /// <param name"value">String to check</param>
        /// <returns></returns>
        MethodsConventionBuilder EndsWith(string value);

        /// <summary>
        /// Determine if method name contains with given value
        /// </summary>
        /// <param name"value">String to check</param>
        /// <returns></returns>
        MethodsConventionBuilder Contains(string value);

        /// <summary>
        /// Determine if method name match given predicate
        /// </summary>
        /// <param name"predicate">Filter function which takes name as parameter</param>
        /// <returns></returns>
        MethodsConventionBuilder Contains(Predicate<string> predicate);

        /// <summary>
        /// Determine if method contains given attribute
        /// </summary>
        /// <typeparam name"TAttribute">Type of <see cref"Attribute"/></typeparam>
        /// <returns></returns>
        MethodsConventionBuilder HasAttribute<TAttribute>() where TAttribute : Attribute;

        /// <summary>
        /// Determine if method returns given type
        /// </summary>
        /// <typeparam name"TResult">Expected return type of method</typeparam>
        /// <returns></returns>
        MethodsConventionBuilder Returns<TResult>();

        /// <summary>
        /// Determine if method contain parameter of given type
        /// </summary>
        /// <typeparam name"T">Type of parameter</typeparam>
        /// <returns></returns>
        MethodsConventionBuilder HasParameterOfType<T>();

        /// <summary>
        /// Determine if method contain parameter of given type
        /// </summary>
        /// <param name"type">Type of parameter</param>
        /// <returns></returns>
        MethodsConventionBuilder HasParameterOfType(Type type);

        /// <summary>
        /// Determine if method has no more than given parameters count
        /// </summary>
        /// <param name"value">Expected maximum parameters count</param>
        /// <returns></returns>
        MethodsConventionBuilder HasMaximumParametersCount(int value);

        /// <summary>
        /// Determine if method has less or equal than given parameters count
        /// </summary>
        /// <param name"value">Expected minimum parameters count</param>
        /// <returns></returns>
        MethodsConventionBuilder HasMinimumParametersCount(int value);

        /// <summary>
        /// Determine if method has given parameters count
        /// </summary>
        /// <param name"value">Expected parameters count</param>
        /// <returns></returns>
        MethodsConventionBuilder HasMParametersCount(int value);
    }
}