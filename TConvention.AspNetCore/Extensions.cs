using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TConvention.Core;
using TConvention.Core.Builders;
using TConvention.Core.Conventions.Classes;
using TConvention.Core.Conventions.Methods;


namespace TConvention.AspNetCore
{
    public static class Extensions
    {
        public static IConventionRoot Has(this Assembly assembly)
        {
            return new AspNetCoreConventionRoot(assembly);
        }

        public static MethodsConventionBuilder Returns<T>(this MethodsConventionBuilder @this)
        {
            var convention = new ReturnTypeMethodConvention<T>();

            return @this;
        }

        public static MethodsConventionBuilder Attribute<T>(this MethodsConventionBuilder @this)
            where T : Attribute
        {
            var convention = new AttributeMethodConvention<T>();

            return @this;
        }

        public static ClassConventionBuilder DeriveFrom<T>(this ClassConventionBuilder @this)
            where T : class
        {
            var convention = new DeriveFromClassConvention<T>();

            return @this;
        }

        public static ClassConventionBuilder NameStartsWith(this ClassConventionBuilder @this, string value)
        {
            var convention = new NameClassConvention(name => name.StartsWith(value));

            return @this;
        }

        public static ClassConventionBuilder NameEndsWith(this ClassConventionBuilder @this, string value)
        {
            var convention = new NameClassConvention(name => name.EndsWith(value));

            return @this;
        }

        public static List<MethodInfo> GetMethods(this Assembly assembly)
        {
            var classes = from type in assembly.GetTypes()
                          where type.IsClass && type.Name != "Program" && type.Name != "Startup"
                          select type;


            var names = from type in classes
                        from method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                        where method.DeclaringType == type
                        select method;

            var a = names.ToList();


            return a;
        }
    }
}
