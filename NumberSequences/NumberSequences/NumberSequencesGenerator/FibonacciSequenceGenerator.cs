using System;
using System.Collections;

namespace NumberSequences.NumberSequencesGenerator
{
    public class FibonacciSequenceGenerator : SequenceGenerator, IEnumerable
    {
        public FibonacciSequenceGenerator() : base()
        {
        }

        public override event EventHandler DoNotHaveElementsInSequence;

        public override IEnumerator GetEnumerator()
        {
            if (this.IsInitialized)
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
            else
            {
                throw new ArgumentNullException("The sequence is not initialized!");
            }
        }

        private void GetNext(ref int firstElement, ref int secondElement)
        {
            secondElement = firstElement + secondElement;
            firstElement = secondElement - firstElement;
        }
    }
}
