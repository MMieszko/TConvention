using System;

namespace TConvention.Core
{
    public class InterfaceComponent : Component<Type>
    {
        public InterfaceComponent(Type nativeElement) : base(nativeElement)
        {
        }

        public override string GetName()
        {
            return NativeElement.Name;
        }
    }
}