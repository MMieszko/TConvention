using Client.Console.Asserts.Methods;
using Client.Console.Filters.Modifiers;

namespace Client.Console.Asserts.Constructors
{
    public interface IConstructorAssert : IAssert,
        IModifierComponentCountConvention<ConstructorModifier, IConstructorAssert>,
        IArgumentComponentCountConvention<IMethodAssert>
    {
        
    }
}