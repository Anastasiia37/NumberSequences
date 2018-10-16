using System;
using System.Collections;

namespace NumberSequences.NumberSequencesGenerator
{
    public class SquareLessNSequenceGenerator : SequenceGenerator
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

                if (elementOfSequence * elementOfSequence >= this.BoundaryValue)
                {
                    this.DoNotHaveElementsInSequence?.Invoke(this, EventArgs.Empty);
                    yield break;
                }

                while (elementOfSequence * elementOfSequence < this.BoundaryValue)
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
    }
}
