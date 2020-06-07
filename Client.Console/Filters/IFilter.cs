using Client.Console.Components;

namespace Client.Console.Filters.Classes
{
    public interface IFilter
    {

    }

    public interface IFilter<out TComponent> : IFilter
        where TComponent : IComponent
    {
        TComponent[] Components { get; }
    }
}