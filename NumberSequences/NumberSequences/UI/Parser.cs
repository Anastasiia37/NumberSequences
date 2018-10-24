// <copyright file="Parser.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using NumberSequences.NumberSequencesGenerator;

namespace NumberSequences.UI
{
    public static class Parser
    {
        public static void Parse(
            string[] args,
            out ISequenceGenerator sequenceGenerator,
            out int boundaryValue, 
            out int? startValue)
        {
            if (args.Length < (int)ArgumentsCount.Minimum)
            {
                throw new ArgumentException("You do not have enough arguments! "
                    + "Please, enter the correct number of arguments!");
            }

            if (args.Length > (int)ArgumentsCount.Maximum)
            {
                throw new ArgumentException("You have too many arguments! "
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
                    throw new ArgumentException("Please, enter correct algorithm "
                            + "for searching the sequence");
            }

            if (!int.TryParse(args[1], out boundaryValue))
            {
                throw new ArgumentException("The second argument is not a number or is a too big number!");
            }

            startValue = null;
            if (args.Length == (int)ArgumentsCount.Maximum)
            {
                int thirdArgument;
                if (!int.TryParse(args[2], out thirdArgument))
                {
                    throw new ArgumentException("The third argument is not a number!");
                }
                else
                {
                    startValue = thirdArgument;
                    if (startValue - boundaryValue > 0)
                    {
                        throw new ArgumentException("The third argument (boundary value) can not be "
                            + "bigger than second (start value)! Please, check your arguments!");
                    }

                    if (startValue < 0 || boundaryValue < 0)
                    {
                        throw new ArgumentException("Arguments can not be negative!");
                    }
                }
            }
        }
    }
}