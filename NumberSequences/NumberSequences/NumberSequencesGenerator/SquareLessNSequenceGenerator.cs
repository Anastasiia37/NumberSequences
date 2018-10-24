// <copyright file="SquareLessNSequenceGenerator.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using System.Collections;

namespace NumberSequences.NumberSequencesGenerator
{
    public class SquareLessNSequenceGenerator : NumberSequenceGenerator
    {
        public SquareLessNSequenceGenerator() : base()
        {
            this.MinimumValue = 1;
        }

        public override event EventHandler DoNotHaveElementsInSequence;

        public override IEnumerator GetEnumerator()
        {
            if (this.IsInitialized)
            {
                int elementOfSequence = this.StartValue;

                if (GetNext(ref elementOfSequence) >= this.BoundaryValue)
                {
                    this.DoNotHaveElementsInSequence?.Invoke(this, EventArgs.Empty);
                    yield break;
                }

                while (GetNext(ref elementOfSequence) < this.BoundaryValue)
                {
                    yield return elementOfSequence;
                    elementOfSequence++;
                }
            }        
            else
            {
                throw new ArgumentNullException("The sequence is not initialized!");
            }
        }

        private int GetNext(ref int elementOfSequence)
        {
            try
            { 
            checked
                { 
                    return elementOfSequence * elementOfSequence;
                }
            }
            catch(OverflowException)
            {
                return this.BoundaryValue + 1;
            }
        }
    }
}