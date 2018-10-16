using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSequences.NumberSequencesGenerator;

namespace NumberSequencesTests
{
    [TestClass]
    public class NumberSequencesTests
    {
        [DataTestMethod]
        /// <param name="startValue"></param>
        /// <param name="boundaryValue"></param>
        /// <param name="expected"></param>
        [DataRow(0, 7, new int[] { 0, 1, 1, 2, 3, 5 })]
        [DataRow(1, 3, new int[] { 1, 1, 2, 3 })]
        [DataRow(6, 13, new int[] { 8, 13 })]
        [DataRow(6, 6, new int[] { })]
        [DataRow(14, 15, new int[] { })]
        public void FibonacciSequenceGeneratorTest_GetEnumerator_CorrectInputForTwoArguments(int startValue, int boundaryValue, int[] expected)
        {
            //Arrange
            FibonacciSequenceGenerator fb = new FibonacciSequenceGenerator();
            fb.Initialize(startValue, boundaryValue);
            int[] actual = new int[0];

            //Act
            int i=0;
            foreach (int element in fb)
            {
                Console.WriteLine(element);
                Array.Resize<int>(ref actual, i + 1);
                actual[i] = element;
                i++;
            }

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        /// <param name="startValue"></param>
        /// <param name="boundaryValue"></param>
        /// <param name="expected"></param>
        [DataRow(9, new int[] { 0, 1, 1, 2, 3, 5, 8 })]
        [DataRow(5, new int[] { 0, 1, 1, 2, 3, 5 })]
        [DataRow(1, new int[] { 0, 1, 1 })]
        [DataRow(0, new int[] { 0 })]
        //[DataRow(6, 5, new int[] { })]
        public void FibonacciSequenceGeneratorTest_GetEnumerator_CorrectInputForOneArguments(int boundaryValue, int[] expected)
        {
            //Arrange
            FibonacciSequenceGenerator fb = new FibonacciSequenceGenerator();
            fb.Initialize(boundaryValue);
            int[] actual = new int[0];

            //Act
            int i = 0;
            foreach (int element in fb)
            {
                Console.WriteLine(element);
                Array.Resize<int>(ref actual, i + 1);
                actual[i] = element;
                i++;
            }

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }


        [ExpectedException(typeof(ArgumentException), "Exception \"ArgumentException\" was not throw")]
        [DataTestMethod]
        [DataRow(6, 5)]
        [DataRow(-1, 5)]
        [DataRow(-3, -1)]
        public void FibonacciSequenceGeneratorTest_Initialize_IncorrectInputForTwoArguments(int startValue, int boundaryValue)
        {
            //Arrange
            FibonacciSequenceGenerator fb = new FibonacciSequenceGenerator();

            //Act
            fb.Initialize(startValue, boundaryValue);
        }

        [ExpectedException(typeof(ArgumentException),
            "Exception \"ArgumentException\" has not been thrown")]
        [DataTestMethod]
        [DataRow(-1)]
        public void FibonacciSequenceGeneratorTest_Initialize_IncorrectInputForOneArguments(int boundaryValue)
        {
            //Arrange
            FibonacciSequenceGenerator fb = new FibonacciSequenceGenerator();

            //Act
            fb.Initialize(boundaryValue);
        }

        [ExpectedException(typeof(ArgumentNullException),
            "Exception \"ArgumentNullException\" has not been thrown")]
        [TestMethod]
        public void FibonacciSequenceGeneratorTest_Initialize_DoNotInitializeGenerator()
        {
            //Arrange
            FibonacciSequenceGenerator fb = new FibonacciSequenceGenerator();

            //Act
            foreach (int element in fb)
            {
                Console.WriteLine(element);
            }
        }

        [DataTestMethod]
        /// <param name="startValue"></param>
        /// <param name="boundaryValue"></param>
        /// <param name="expected"></param>
        [DataRow(1, 26, new int[] { 1, 2, 3, 4, 5 })]
        [DataRow(3, 24, new int[] { 3, 4 })]
        [DataRow(4, 36, new int[] { 4, 5 })]
        [DataRow(3, 16, new int[] { 3 })]
        [DataRow(4, 16, new int[] { })]
        [DataRow(4, 15, new int[] { })]
        public void SquareLessNSequenceGeneratorTest_GetEnumerator_CorrectInputForTwoArguments(int startValue, int boundaryValue, int[] expected)
        {
            //Arrange
            SquareLessNSequenceGenerator fb = new SquareLessNSequenceGenerator();
            fb.Initialize(startValue, boundaryValue);
            int[] actual = new int[0];

            //Act
            int i = 0;
            foreach (int element in fb)
            {
                Console.WriteLine(element);
                Array.Resize<int>(ref actual, i + 1);
                actual[i] = element;
                i++;
            }

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(ArgumentException), "Exception \"ArgumentException\" was not throw")]
        [DataTestMethod]
        [DataRow(0, 25)]
        [DataRow(-1, 5)]
        [DataRow(-3, -1)]
        [DataRow(6, 5)]
        public void SquareLessNSequenceGeneratorTest_Initialize_IncorrectInputForTwoArguments(int startValue, int boundaryValue)
        {
            //Arrange
            SquareLessNSequenceGenerator fb = new SquareLessNSequenceGenerator();

            //Act
            fb.Initialize(startValue, boundaryValue);
        }



        [DataTestMethod]
        /// <param name="startValue"></param>
        /// <param name="boundaryValue"></param>
        /// <param name="expected"></param>
        [DataRow(9, new int[] { 1, 2 })]
        [DataRow(10, new int[] { 1, 2, 3 })]
        [DataRow(1, new int[] { })]
        public void SquareLessNSequenceGeneratorTest_GetEnumerator_CorrectInputForOneArguments(int boundaryValue, int[] expected)
        {
            //Arrange
            SquareLessNSequenceGenerator fb = new SquareLessNSequenceGenerator();
            fb.Initialize(boundaryValue);
            int[] actual = new int[0];

            //Act
            int i = 0;
            foreach (int element in fb)
            {
                Console.WriteLine(element);
                Array.Resize<int>(ref actual, i + 1);
                actual[i] = element;
                i++;
            }

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }


        [ExpectedException(typeof(ArgumentException),
            "Exception \"ArgumentException\" has not been thrown")]
        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        public void SquareLessNSequenceGeneratorTest_Initialize_IncorrectInputForOneArguments(int boundaryValue)
        {
            //Arrange
            SquareLessNSequenceGenerator fb = new SquareLessNSequenceGenerator();

            //Act
            fb.Initialize(boundaryValue);
        }

        [ExpectedException(typeof(ArgumentNullException),
            "Exception \"ArgumentNullException\" has not been thrown")]
        [TestMethod]
        public void SquareLessNSequenceGeneratorTest_Initialize_DoNotInitializeGenerator()
        {
            //Arrange
            SquareLessNSequenceGenerator fb = new SquareLessNSequenceGenerator();

            //Act
            foreach (int element in fb)
            {
                Console.WriteLine(element);
            }
        }


    }
}
