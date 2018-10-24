// <copyright file="SquareLessNSequenceGeneratorTests.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSequences.NumberSequencesGenerator;

namespace NumberSequencesTests
{
    /// <summary>
    /// Summary description for SquareLessNSequenceGeneratorTests
    /// </summary>
    [TestClass]
    public class SquareLessNSequenceGeneratorTests
    {
        [ExpectedException(typeof(ArgumentException), "Exception \"ArgumentException\" was not throw")]
        [DataTestMethod]
        [DataRow(0, 25)]
        [DataRow(-1, 5)]
        [DataRow(-3, -1)]
        [DataRow(6, 5)]
        public void InitializeTest_IncorrectInputForTwoArguments_ExpectedException(int startValue, int boundaryValue)
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
        public void GetEnumeratorTest_CorrectInputForOneArgument(int boundaryValue, int[] expected)
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

        [DataTestMethod]
        /// <param name="startValue"></param>
        /// <param name="boundaryValue"></param>
        /// <param name="expected"></param>
        [DataRow(9, 2, new int[] { 2 })]
        [DataRow(10, 2, new int[] { 2, 3 })]
        [DataRow(3, 2, new int[] { })]
        public void GetEnumeratorTest_CorrectInputForTwoArgument(int boundaryValue, int startValue, int[] expected)
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



        [ExpectedException(typeof(ArgumentException),
            "Exception \"ArgumentException\" has not been thrown")]
        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        public void InitializeTest_IncorrectInputForOneArgument_ExpectedException
            (int boundaryValue)
        {
            //Arrange
            SquareLessNSequenceGenerator fb = new SquareLessNSequenceGenerator();

            //Act
            fb.Initialize(boundaryValue);
        }

        [ExpectedException(typeof(ArgumentNullException),
            "Exception \"ArgumentNullException\" has not been thrown")]
        [TestMethod]
        public void InitializeTest_DoNotInitializeGenerator_ExpectedException()
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