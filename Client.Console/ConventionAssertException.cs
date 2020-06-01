using System;
using Client.Console.Components;

namespace Client.Console
{
    public class ConventionAssertException : Exception
    {
        public IComponent[] Components { get; }

        public ConventionAssertException(IComponent[] components, string message) : base(message)
        {
            Components = components;
        }
    }
}