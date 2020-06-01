using System;
using System.Linq;
using Client.Console.Asserts.Properties;
using Client.Console.Components;
using Client.Console.Extensions;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Filters.Properties
{
    public class PropertyFilter : IPropertyFilter
    {
        protected Property[] Properties;

        public PropertyFilter(Property[] classes)
        {
            Properties = classes;
        }

        public IPropertyFilter All()
        {
            return this;
        }

        public IPropertyFilter WithModifier(PropertyModifier modifier)
        {
            this.Properties = Properties.FilterByModifier(modifier);

            return this;
        }

        public IPropertyFilter WithType<T>()
        {
            this.Properties = Properties.FilterByType<T>();

            return this;
        }

        public IPropertyFilter WithAttribute<T>()
            where T : Attribute
        {
            this.Properties = this.Properties.FilterByAttribute<T>();

            return this;
        }
    }
}