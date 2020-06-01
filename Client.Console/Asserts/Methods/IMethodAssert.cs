using Client.Console.Filters.Modifiers;

namespace Client.Console.Asserts.Methods
{
    public interface IMethodAssert : IAssert,
        IAttributeContainsConvention<IMethodAssert>,
        IModifierComponentCountConvention<MethodModifier, IMethodAssert>,
        IArgumentComponentCountConvention<IMethodAssert>
    {
        IMethodAssert ReturnsAsync(string because = null);
        IMethodAssert Returns<TResult>(string because = null);
        IMethodAssert ReturnsAsync<TResult>(string because = null);
    }
}