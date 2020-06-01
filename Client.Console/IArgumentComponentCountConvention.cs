using Client.Console.Asserts;

namespace Client.Console
{
    public interface IArgumentComponentCountConvention<out TConventionBuilder>
        where TConventionBuilder : IAssert
    {
        TConventionBuilder HasMaximumArgumentsCount(int count);
        TConventionBuilder HasMinimumArgumentsCount(int count);
    }
}