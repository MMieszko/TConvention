using System;
using System.Linq;
using Core.Components;
using Core.Modifiers;

namespace Core.Filters.Properties
{
    public class PropertyFilter : Filter<Property, PropertyModifier>, IPropertyFilter
    {
        public PropertyFilter(Property[] props)
            :base(props)
        {
            
        }

        public IPropertyFilter WithModifier(PropertyModifier modifier)
        {
            return new PropertyFilter(Components.Where(x => x.Is(modifier)).ToArray());
        }

        public IPropertyFilter Static()
        {
            return this.WithModifier(PropertyModifier.Static);
        }

        public IPropertyFilter Abstract()
        {
            return this.WithModifier(PropertyModifier.Abstract);
        }

        public IPropertyFilter PublicWithProtectedSet()
        {
            return this.WithModifier(PropertyModifier.PublicGet | PropertyModifier.ProtectedSet);
        }

        public IPropertyFilter PublicWithPrivateSet()
        {
            return this.WithModifier(PropertyModifier.PublicGet | PropertyModifier.PrivateSet);
        }

        public IPropertyFilter Public()
        {
            return this.WithModifier(PropertyModifier.PublicGet | PropertyModifier.PublicSet);
        }

        public IPropertyFilter Private()
        {
            return this.WithModifier(PropertyModifier.PrivateGet | PropertyModifier.PrivateSet);
        }

        public IPropertyFilter Protected()
        {
            return this.WithModifier(PropertyModifier.ProtectedGet | PropertyModifier.ProtectedSet);
        }

        public IPropertyFilter PublicReadonly()
        {
            return this.WithModifier(PropertyModifier.PublicGet | PropertyModifier.Readonly);
        }

        public IPropertyFilter ProtectedReadonly()
        {
            return this.WithModifier(PropertyModifier.ProtectedGet | PropertyModifier.Readonly);
        }

        public IPropertyFilter PrivateReadonly()
        {
            return this.WithModifier(PropertyModifier.PrivateGet | PropertyModifier.Readonly);
        }

        public IPropertyFilter WithType<T>()
        {
            return new PropertyFilter(Components.Where(x => x.ReturnType == typeof(T)).ToArray());
        }

        public IPropertyFilter WithAttribute<T>()
            where T : Attribute
        {
            return (IPropertyFilter) base.FilterAttributes<T>();
        }
    }
}