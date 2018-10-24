// <copyright file="FibonacciSequenceGeneratorTests.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSequences.NumberSequencesGenerator;

namespace NumberSequencesTests
{
    [TestClass]
    public class FibonacciSequenceGeneratorTests
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
        public void GetEnumeratorTest_CorrectInputForTwoArguments(int startValue, int boundaryValue, int[] expected)
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
        public void GetEnumeratorTest_CorrectInputForOneArguments(int boundaryValue, int[] expected)
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
        public void InitializeTest_IncorrectInputForTwoArguments_ExpectedException
            (int startValue, int boundaryValue)
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
        public void InitializeTest_IncorrectInputForOneArguments_ExpectedException
            (int boundaryValue)
        {
            //Arrange
            FibonacciSequenceGenerator fb = new FibonacciSequenceGenerator();

            //Act
            fb.Initialize(boundaryValue);
        }

        [ExpectedException(typeof(ArgumentNullException),
            "Exception \"ArgumentNullException\" has not been thrown")]
        [TestMethod]
        public void InitializeTest_DoNotInitializeGenerator_ExpectedException()
        {
            //Arrange
            FibonacciSequenceGenerator fb = new FibonacciSequenceGenerator();

            //Act
            foreach (int element in fb)
            {
                Console.WriteLine(element);
            }
        }
    }
}