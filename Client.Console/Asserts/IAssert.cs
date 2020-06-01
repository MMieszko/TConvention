namespace Client.Console.Asserts
{
    public interface IAssert<TConcrete> : IAssert
        where TConcrete : IAssert
    {

    }

    public interface IAssert
    {

    }
}