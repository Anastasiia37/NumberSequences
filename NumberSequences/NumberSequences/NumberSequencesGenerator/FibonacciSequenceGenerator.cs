// <copyright file="FibonacciSequenceGenerator.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using System.Collections;

namespace NumberSequences.NumberSequencesGenerator
{
    public class FibonacciSequenceGenerator : NumberSequenceGenerator, IEnumerable
    {
        public FibonacciSequenceGenerator() : base()
        {
        }

        public override event EventHandler DoNotHaveElementsInSequence;

        public override IEnumerator GetEnumerator()
        {
            try
            {
                if (this.IsInitialized)
                {
                    checked
                    {
                        int firstElement = 0;
                        int secondElement = 1;
                        while (firstElement < this.StartValue)
                        {
                            this.GetNext(ref firstElement, ref secondElement);
                        }

                        if (firstElement > this.BoundaryValue)
                        {
                            this.DoNotHaveElementsInSequence?.Invoke(this, EventArgs.Empty);
                            yield break;
                        }

                        while (!(firstElement > this.BoundaryValue))
                        {
                            yield return firstElement;
                            this.GetNext(ref firstElement, ref secondElement);
                        }
                    }
                }
                else
                {
                    throw new ArgumentNullException("The sequence is not initialized!");
                }
            }

            finally
            {
            }
        }

        private void GetNext(ref int firstElement, ref int secondElement)
        {
            try
            {
                checked
                {
                    secondElement = firstElement + secondElement;
                    firstElement = secondElement - firstElement;
                }
            }
            catch(OverflowException)
            {
                firstElement = BoundaryValue + 1;
            }
        }
    }
}