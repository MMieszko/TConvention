using System;

namespace TConvention.Core
{
    public class ClassComponent : Component<Type>
    {
        public ClassComponent(Type nativeElement)
            : base(nativeElement)
        {
        }

        public override string GetName()
        {
            return base.NativeElement.Name;
        }
    }
}