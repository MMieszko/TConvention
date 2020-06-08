using System.Collections.Generic;

namespace Client.Domain
{
    public class UserCode : ValueObject
    {
        public string Value { get; }

        public UserCode(string value)
        {
            this.Value = value;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.Value;
        }
    }
}