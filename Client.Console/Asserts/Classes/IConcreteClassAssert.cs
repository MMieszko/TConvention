namespace Client.Console.Asserts.Classes
{
    public interface IConcreteClassAssert<TClass> : IClassAssert
    {
        IClassAssert Inherit<T>() where T : class;
    }
}