using System.Collections.Generic;
using TConvention.Core.Conventions;

namespace TConvention.Core.Modules
{
    public abstract class Module
    {
        public List<IConvention> Conventions;

        protected Module(List<IConvention> conventions)
        {

        }
    }
}