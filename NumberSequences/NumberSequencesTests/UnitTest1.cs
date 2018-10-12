using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSequences.NumberSequencesGenerator;

namespace NumberSequencesTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FibonacciSequenceGenerator()
        {
            FibonacciSequenceGenerator fb = new FibonacciSequenceGenerator();
            foreach (var i in fb)
                Console.WriteLine(i);

            }
        }
}
