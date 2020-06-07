using System.Linq;
using Core.Components;
using Core.Modifiers;

namespace Core.Filters.Constructors
{
    public class ConstructorFilter : Filter<Constructor>, IConstructorFilter
    {
        public ConstructorFilter(Constructor[] constructors)
            :base(constructors)
        {
            
        }

        public IConstructorFilter Public()
        {
            return this.WithModifier(ConstructorModifier.Public);
        }

        public IConstructorFilter Internal()
        {
            return this.WithModifier(ConstructorModifier.Internal);
        }

        public IConstructorFilter Protected()
        {
            return this.WithModifier(ConstructorModifier.Protected);
        }

        public IConstructorFilter Private()
        {
            return this.WithModifier(ConstructorModifier.Private);
        }

        public IConstructorFilter Static()
        {
            return this.WithModifier(ConstructorModifier.Static);
        }

        public IConstructorFilter WithModifier(ConstructorModifier modifier)
        {
            return new ConstructorFilter(Components.Where(x => x.Is(modifier)).ToArray());
        }
    }
}