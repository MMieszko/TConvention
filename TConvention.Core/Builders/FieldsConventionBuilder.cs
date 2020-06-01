using System;

namespace TConvention.Core.Builders
{
    public class FieldsConventionBuilder : IConventionBuilder
    {
        private ConventionRoot _conventionRoot;

        public FieldsConventionBuilder(ConventionRoot conventionRoot)
        {
            _conventionRoot = conventionRoot;
        }

        public ConventionRoot AndHas()
        {
            throw new NotImplementedException();
        }
    }
}