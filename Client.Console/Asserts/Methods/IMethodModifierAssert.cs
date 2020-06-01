namespace Client.Console.Asserts.Methods
{
    public interface IMethodModifierAssert : IMethodAssert
    {
        IMethodModifierAssert HaveMaximumCount(int count);
        IMethodModifierAssert HaveMinimumCount(int count);
    }
}