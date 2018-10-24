// <copyright file="SequenceGeneratorProgram.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using System.Text;
using NumberSequences.NumberSequencesGenerator;

namespace NumberSequences.UI
{
    public class SequenceGeneratorProgram
    {
        private ISequenceGenerator sequenceGenerator;

        public int Run(string[] args)
        {
            int? startValue;
            int boundaryValue;

            try
            {
                Parser.Parse(args, out this.sequenceGenerator, out boundaryValue, out startValue);
                if (startValue == null)
                {
                    this.sequenceGenerator.Initialize(boundaryValue);
                }
                else
                {
                    this.sequenceGenerator.Initialize(startValue.Value, boundaryValue);
                }

                this.PrintSequence();                
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                this.Instructions();
                return (int)ReturnCode.Error;
            }

            return (int)ReturnCode.Success;
        }

        private void PrintSequence()
        {
            this.sequenceGenerator.DoNotHaveElementsInSequence += (sender, eventArgs) =>
                Console.Write("Requested sequence doesn`t have elements!");
            Console.Write("Your sequence: ");
            StringBuilder consoleString = new StringBuilder();
            foreach (int element in this.sequenceGenerator)
            {
                consoleString.Append(element);
                consoleString.Append(", ");
            }

            if (consoleString.Length > 2)
            {
                consoleString.Length -= 2;
            }

            Console.WriteLine(consoleString);
        }

        private void Instructions()
        {
            Console.WriteLine("Input arguments: SequenceGenerator Border [StartWith]\n"
                + "SequenceGenerator = fibonacci or squarelessn\n"
                + "Border is the boundary value of a sequence (up to 2.147.483.646)\n"
                + "StartWith is the start value of sequence\n");
        }
    }
}