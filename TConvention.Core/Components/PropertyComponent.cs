using System.Reflection;

namespace TConvention.Core
{
    public class PropertyComponent : Component<PropertyInfo>
    {
        public PropertyComponent(PropertyInfo nativeElement) : base(nativeElement)
        {
        }

        public override string GetName()
        {
            return base.NativeElement.Name;
        }
    }
}