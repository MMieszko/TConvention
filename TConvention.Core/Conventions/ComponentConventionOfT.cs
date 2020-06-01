using System.Collections.Generic;

namespace TConvention.Core.Conventions
{
    public abstract class ComponentConvention<TComponent, TNative> : IConvention
        where TComponent : Component<TNative>
        where TNative : class
    {
        public virtual IEnumerable<TNative> Filter(List<TNative> components)
        {
            return components;
        }
        public abstract bool IsValid(TNative component);
    }
}