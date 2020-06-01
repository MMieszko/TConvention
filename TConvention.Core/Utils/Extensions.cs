using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TConvention.Core.Utils
{
    public static class Extensions
    {
        //public static ConventionRoot Has(this Assembly assembly)
        //{
        //    return new ConventionRoot(assembly);
        //}

        //public static List<MethodInfo> GetMethods(this Assembly assembly)
        //{
        //    var names = from type in assembly.GetTypes()
        //                from method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
        //                select method;



        //    var classes = from type in assembly.GetTypes().Skip(1)
        //                  from method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
        //                  where type.IsClass
        //                  select method;


        //    var a = names.ToList();


        //    var b = a.Where(x => !x.Attributes.HasFlag(MethodAttributes.SpecialName)).ToList();


        //    var c = a.FirstOrDefault(x => x.Name.Contains("chuj"));


        //    var d = classes.ToList();

        //    return a;
        //}
    }
}