using Core.Components;

namespace Core.Filters.Constructors
{
    public interface IConstructorFilter : IFilter<Constructor>
    {
        IConstructorFilter Public();
        IConstructorFilter Internal();
        IConstructorFilter Protected();
        IConstructorFilter Private();
        IConstructorFilter Static();
    }
}