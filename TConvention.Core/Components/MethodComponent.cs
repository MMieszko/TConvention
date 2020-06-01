using System.Reflection;

namespace TConvention.Core
{
    public class MethodComponent : Component<MethodInfo>
    {
        public MethodComponent(MethodInfo nativeElement) : base(nativeElement)
        {
        }

        public override string GetName()
        {
            return base.NativeElement.Name;
        }
    }
}