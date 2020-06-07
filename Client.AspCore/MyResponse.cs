namespace Client.AspCore
{
    public class MyResponse<T> : MyResponse
    {
        public T Result { get; }
    }

    public class MyResponse  : IResponse
    {
        public bool Suceeded { get; }
        public string Message { get; }
    }

    public interface IResponse
    {
        bool Suceeded { get; }
        string Message { get; }
    }

}