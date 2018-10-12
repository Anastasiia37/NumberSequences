using System;
using NumberSequences.NumberSequencesGenerator;

namespace NumberSequences.UI
{
    internal class SequenceGeneratorProgram
    {
        private ISequenceGenerator sequenceGenerator;

        public int Run(string[] args)
        {
            int start;
            int? end;

            try
            {
                Validator.Parse(args, out this.sequenceGenerator, out start, out end);
                if (end == null)
                {
                    this.sequenceGenerator.Initialize(start);
                }
                else
                {
                    this.sequenceGenerator.Initialize(start, end.Value);
                }

                foreach (int element in this.sequenceGenerator)
                {
                    Console.WriteLine(element);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                this.Instructions();
                return (int)ReturnCode.Error;
            }

            return (int)ReturnCode.Success;
        }

        private void Instructions()
        {
            Console.WriteLine("Input arguments: SequenceGenerator Border [StartWith]\n"
                + "SequenceGenerator = fibonacci or squarelessn\n"
                + "Border is the boundary value of a sequence\n"
                + "StartWith is the start value of sequence\n");
        }
    }
}
