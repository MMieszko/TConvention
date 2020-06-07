using Core.Components;
using Core.Modifiers;

namespace Core.Filters.Constructors
{
    public class ConstructorFilter : Filter<Constructor, ConstructorModifier>, IConstructorFilter
    {
        public ConstructorFilter(Constructor[] constructors)
            :base(constructors)
        {
            
        }
    }
}