using System;
using Client.Console.Asserts.Fields;
using Client.Console.Components;
using Client.Console.Extensions;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Filters.Fields
{
    public class FieldFilter : IFieldFilter
    {
        protected Field[] Fields;

        public FieldFilter(Field[] fields)
        {
            Fields = fields;
        }

        public virtual IFieldFilter All()
        {
            return this;
        }

        public virtual IFieldFilter WithModifier(FieldModifier modifier)
        {
            this.Fields = Fields.FilterByModifier(modifier);

            return this;
        }

        public virtual IFieldFilter WithType<T>()
        {
            this.Fields = Fields.FilterByType<T>();

            return this;
        }

        public virtual IFieldFilter WithAttribute<TAttribute>()
            where TAttribute : Attribute
        {
            this.Fields = Fields.FilterByAttribute<TAttribute>();

            return this;
        }
    }
}