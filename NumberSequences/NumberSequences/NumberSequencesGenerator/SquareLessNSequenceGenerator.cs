using System;
using System.Collections;

namespace NumberSequences.NumberSequencesGenerator
{
    public class SquareLessNSequenceGenerator : SequenceGenerator
    {        
        public SquareLessNSequenceGenerator() : base()
        {
            this.minimumValue = 1;
        }

        public override IEnumerator GetEnumerator()
        {
            if (this.IsInitialized)
            {
                int elementOfSequence = this.StartWith;
                while (elementOfSequence * elementOfSequence < this.Border)
                {
                    yield return elementOfSequence;
                    elementOfSequence++;
                }
            }
        }
    }
}
