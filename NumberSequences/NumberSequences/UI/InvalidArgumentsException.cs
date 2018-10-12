using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
