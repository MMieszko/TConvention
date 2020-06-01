using Client.Console.Components;

namespace Client.Console.Asserts
{
    public class Assert<TComponent>
        where TComponent : IComponent
    {
        protected TComponent[] Components;

        public Assert(TComponent[] components)
        {
            Components = components;
        }
    }
}