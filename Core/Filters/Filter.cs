using System;
using Core.Components;

namespace Core.Filters
{
    public class Filter<TComponent> : IFilter<TComponent>
        where TComponent : IComponent
    {
        public TComponent[] Components { get; }

        public Filter(TComponent[] components)
        {
            this.Components = components;
        }
    }
}