using System;

namespace NumberSequences.UI
{
    internal class InvalidArgumentsValueException : InvalidArgumentsException
    {
        public InvalidArgumentsValueException() : base()
        {
        }

        public InvalidArgumentsValueException(string message) : base(message)
        {
        }

        public InvalidArgumentsValueException(string message, Exception innerException) :
            base(message, innerException)
        {
        }
    }
}
