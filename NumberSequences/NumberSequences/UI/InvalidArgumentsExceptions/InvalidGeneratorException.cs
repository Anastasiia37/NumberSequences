using System;

namespace NumberSequences.UI
{
    internal class InvalidGeneratorException : InvalidArgumentsException
    {
        public InvalidGeneratorException() : base()
        {
        }

        public InvalidGeneratorException(string message) : base(message)
        {
        }

        public InvalidGeneratorException(string message, Exception innerException) :
            base(message, innerException)
        {
        }
    }
}
