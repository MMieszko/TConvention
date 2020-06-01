using System;
using System.Reflection;
using TConvention.Core.Conventions;

namespace TConvention.Core.Exceptions
{
    public abstract class ConventionException<TConvention, TComponent> : Exception
        where TConvention : ComponentConvention<TComponent>
    {
        public TComponent Component { get; }
        public TConvention Convention { get; }

        protected ConventionException(TConvention convention, TComponent component)
             : base(BuildMessage(convention, component))
        {
            this.Convention = convention;
            this.Component = component;
        }

        private static string BuildMessage(TConvention convention, TComponent component)
        {
            //TODO:
            return $"Failed while executing {convention.GetType().Name} on method {component}";
        }
    }
}