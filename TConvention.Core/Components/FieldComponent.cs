using System.Reflection;

namespace TConvention.Core
{
    public class FieldComponent : Component<FieldInfo>
    {
        public FieldComponent(FieldInfo nativeElement) : base(nativeElement)
        {
        }

        public override string GetName()
        {
            return base.NativeElement.Name;
        }
    }
}