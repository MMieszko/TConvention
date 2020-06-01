namespace TConvention.Core
{
    public abstract class Component<TNative> : IComponent
        where TNative : class
    {
        public TNative NativeElement { get; }

        protected Component(TNative nativeElement)
        {
            this.NativeElement = nativeElement;
        }

        public abstract string GetName();
    }
}