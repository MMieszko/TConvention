using System;
using System.Linq;
using Core.Components;

namespace Core.Filters
{
    public class Filter<TComponent, TModifier> : IFilter<TComponent>
        where TComponent : IComponent
        where TModifier : Enum
    {
        public TComponent[] Components { get; }

        public Filter(TComponent[] components)
        {
            this.Components = components;
        }

        protected Filter<TComponent, TModifier> FilterAttributes<TAttribute>()
            where TAttribute : Attribute
        {
            return new Filter<TComponent, TModifier>(Components.Where(x => x.HasAttribute<TAttribute>()).ToArray());
        }

        
    }
}