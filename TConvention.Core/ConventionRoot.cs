using System.Reflection;
using TConvention.Core.Builders;
using TConvention.Core.Conventions;
using TConvention.Core.Utils;

namespace TConvention.Core
{
    public class ConventionRoot : IConventionRoot
    {
        protected readonly Assembly _assembly;

        public ConventionRoot(Assembly assembly)
        {
            _assembly = assembly;
        }

        public ConventionRoot Module(Module module)
        {
            //
            return this;
        }

        public ClassConventionBuilder Classes()
        {
            return new ClassConventionBuilder();
        }

        public MethodsConventionBuilder Methods()
        {
            return new MethodsConventionBuilder(this);
        }

        public FieldsConventionBuilder FieldConventions()
        {
            return new FieldsConventionBuilder(this);
        }

        public PropertyConventionBuilder PropertyConventions()
        {
            return new PropertyConventionBuilder(this);
        }

        public virtual void AddMethodConventions(params MethodConvention[] conventions)
        {
            var methods = this._assembly.GetMethods();

            foreach (var convention in conventions)
                foreach (var method in methods)
                {
                    if (!convention.IsValid(method))
                    {
                        //throw new MethodConventionException(convention, method);
                    }
                }
        }
    }
}
