using System;
using System.Collections.Generic;
using NumberSequences.NumberSequencesGenerator;

namespace NumberSequences.UI
{
    internal static class Validator
    {
        public static void Parse(string[] args,
                                out ISequenceGenerator sequenceGenerator,
                                out int border, 
                                out int? startWith)
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
            if (sequenceGeneratorType == "fibonacci")
            {
                sequenceGenerator = new FibonacciSequenceGenerator();
            }
            else
            {
                if (sequenceGeneratorType == "squarelessn")
                {
                    sequenceGenerator = new SquareLessNSequenceGenerator();
                }
                else
                {
                    throw new InvalidGeneratorException("Please, enter correct algorithm "
                            + "for searching the sequence");
                }
            }

            if (!int.TryParse(args[1], out border))
            {
                throw new FormatException("The second argument is not a number!");
            }

            int thirdArgument;
            if (args.Length == (int)ArgumentsCount.Maximum)
            {
                if (!int.TryParse(args[2], out thirdArgument))
                {
                    throw new FormatException("The third argument is not a number!");
                }
                else
                {
                    startWith = thirdArgument;
                    if (startWith - border >= 0)
                    {
                        throw new InvalidArgumentsValueException("The third argument can not be "
                            + "bigger than second Please, check your arguments!");
                    }

                    if (startWith < 0 || border < 0)
                    {
                        throw new InvalidArgumentsValueException("Argument can not be "
                            + "negative!");
                    }
                }
            }
            else
            {
                startWith = null;
            }
        }
    }
}
