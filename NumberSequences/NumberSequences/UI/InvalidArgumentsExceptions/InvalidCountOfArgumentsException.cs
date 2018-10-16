using System;

namespace NumberSequences.UI
{
    internal class InvalidCountOfArgumentsException : InvalidArgumentsException
    {
        public InvalidCountOfArgumentsException() : base()
        {
        }

        public InvalidCountOfArgumentsException(string message) : base(message)
        {
        }

        public InvalidCountOfArgumentsException(string message, Exception innerException) :
            base(message, innerException)
        {
        }
    } 
}
