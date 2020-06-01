using Client.Console.Filters.Modifiers;

namespace Client.Console.Asserts.Properties
{
    public interface IPropertyAssert : IAssert,
        IAttributeContainsConvention<IPropertyAssert>,
        IModifierComponentCountConvention<PropertyModifier, IPropertyAssert>
    {
        
    }
}