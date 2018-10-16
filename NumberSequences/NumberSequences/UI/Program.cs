using System;

namespace NumberSequences.UI
{
    public class Program
    {
        public static int Main(string[] args)
        {
            SequenceGeneratorProgram sequenceGeneratorProgram = new SequenceGeneratorProgram();
            return sequenceGeneratorProgram.Run(args);
        }
    }
}
