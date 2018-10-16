using System;
using NumberSequences.NumberSequencesGenerator;

namespace NumberSequences.UI
{
    internal static class Validator
    {
        public static void Parse(
            string[] args,
            out ISequenceGenerator sequenceGenerator,
            out int boundaryValue, 
            out int? startValue)
        {
            if (args.Length < (int)ArgumentsCount.Minimum)
            {
                throw new InvalidCountOfArgumentsException("You do not have enough arguments! "
                    + "Please, enter the correct number of arguments!");
            }

            if (args.Length > (int)ArgumentsCount.Maximum)
            {
                throw new InvalidCountOfArgumentsException("You have too many arguments! "
                    + "Please, enter the correct number of arguments!");
            }

            string sequenceGeneratorType = args[0].ToLower();
            switch (sequenceGeneratorType)
            {
                case "fibonacci":
                    sequenceGenerator = new FibonacciSequenceGenerator();
                    break;
                case "squarelessn":
                    sequenceGenerator = new SquareLessNSequenceGenerator();
                    break;
                default:
                    throw new InvalidGeneratorException("Please, enter correct algorithm "
                            + "for searching the sequence");
            }

            if (!int.TryParse(args[1], out boundaryValue))
            {
                throw new FormatException("The second argument is not a number!");
            }

            startValue = null;
            if (args.Length == (int)ArgumentsCount.Maximum)
            {
                int thirdArgument;
                if (!int.TryParse(args[2], out thirdArgument))
                {
                    throw new FormatException("The third argument is not a number!");
                }
                else
                {
                    startValue = thirdArgument;
                    if (startValue - boundaryValue > 0)
                    {
                        throw new InvalidArgumentsValueException("The third argument (boundary value) can not be "
                            + "bigger than second (start value)! Please, check your arguments!");
                    }

                    if (startValue < 0 || boundaryValue < 0)
                    {
                        throw new InvalidArgumentsValueException("Arguments can not be negative!");
                    }
                }
            }
        }
    }
}
