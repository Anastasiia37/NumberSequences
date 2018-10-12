using System;
using System.Collections;

namespace NumberSequences.NumberSequencesGenerator
{
    public class FibonacciSequenceGenerator : SequenceGenerator
    {
        public FibonacciSequenceGenerator() : base()
        {
        }

        public override IEnumerator GetEnumerator()
        {
            if (this.IsInitialized)
            {
                int firstElement = 0;
                int secondElement = 1;
                while (firstElement != this.StartWith)
                {
                    this.GetNext(ref firstElement, ref secondElement);
                }

                do
                {
                    yield return firstElement;
                    this.GetNext(ref firstElement, ref secondElement);
                }
                while (firstElement <= this.Border);
            }
        }

        private void GetNext(ref int firstElement, ref int secondElement)
        {
            secondElement = firstElement + secondElement;
            firstElement = secondElement - firstElement;
        }
    }
}
