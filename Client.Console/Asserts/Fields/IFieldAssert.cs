using Client.Console.Filters.Modifiers;

namespace Client.Console.Asserts.Fields
{
    public interface IFieldAssert : IAssert,
        IAttributeContainsConvention<IFieldAssert>,
        IModifierComponentCountConvention<FieldModifier, IFieldAssert>
    {

    }
}