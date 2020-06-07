using Core.Components;

namespace Core.Filters
{
    public interface IFilter<out TComponent>
        where TComponent : IComponent
    {
        TComponent[] Components { get; }
    }
}