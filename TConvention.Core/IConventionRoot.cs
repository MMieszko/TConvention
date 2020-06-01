using TConvention.Core.Builders;

namespace TConvention.Core
{
    public interface IConventionRoot
    {
        MethodsConventionBuilder Methods();
        FieldsConventionBuilder FieldConventions();
        PropertyConventionBuilder PropertyConventions();
        ClassConventionBuilder Classes();
    }
}