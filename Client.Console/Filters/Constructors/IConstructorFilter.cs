using Client.Console.Filters.Modifiers;

namespace Client.Console.Filters.Constructors
{
    public interface IConstructorFilter
    {
        IConstructorFilter WithModifier(ConstructorModifier modifier);
    }
}