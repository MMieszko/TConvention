using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Core.Components;
using Core.Filters.Classes;

namespace Core
{
    public class Arrange
    {
        private readonly ICollection<Type> _types;

        private Arrange(Assembly assembly)
        {
            _types = assembly.GetTypes().ToList();

        }

        public static IClassFilter ForAssembly(Assembly assembly)
        {
            return new ClassFilter(assembly.GetTypes().ToList().Select(x => new Class(x)).ToArray());
        }

        public static IClassFilter ForCurrentAssembly()
        {
            throw new NotImplementedException();
        }

        public IClassFilter Classes()
        {
            return null;
        }
    }
}
