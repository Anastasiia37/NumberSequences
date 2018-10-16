using System;

namespace NumberSequences.UI
{
    internal class InvalidArgumentsException : Exception
    {
        public InvalidArgumentsException() : base()
        {
        }

        public InvalidArgumentsException(string message) : base(message)
        {
        }

        public InvalidArgumentsException(string message, Exception innerException) :
            base(message, innerException)
        {
        }
    }
}
