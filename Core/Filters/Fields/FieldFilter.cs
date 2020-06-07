using System;
using System.Linq;
using Core.Components;
using Core.Modifiers;

namespace Core.Filters.Fields
{
    public class FieldFilter : Filter<Field, FieldModifier>, IFieldFilter
    {
        public FieldFilter(Field[] fields)
            : base(fields)
        {

        }

        public virtual IFieldFilter WithModifier(FieldModifier modifier)
        {
            return new FieldFilter(Components.Where(x => x.Is(modifier)).ToArray());
        }

        public IFieldFilter WithAttribute<TAttribute>()
            where TAttribute : Attribute
        {
            return (IFieldFilter)base.FilterAttributes<TAttribute>();
        }

        public virtual IFieldFilter WithType<T>()
        {
            return new FieldFilter(Components.Where(x => x.Type == typeof(T)).ToArray());
        }
    }
}