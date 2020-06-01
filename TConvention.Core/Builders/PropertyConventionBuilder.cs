using System.Reflection;

namespace TConvention.Core.Builders
{
    public class PropertyConventionBuilder : IConventionBuilder
    {
        private readonly ConventionRoot _conventionRoot;

        public PropertyConventionBuilder(ConventionRoot conventionRoot)
        {
            _conventionRoot = conventionRoot;
        }

        public ConventionRoot AndHas()
        {
            throw new System.NotImplementedException();
        }
    }
}