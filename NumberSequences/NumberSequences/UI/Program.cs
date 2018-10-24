// <copyright file="Program.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

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