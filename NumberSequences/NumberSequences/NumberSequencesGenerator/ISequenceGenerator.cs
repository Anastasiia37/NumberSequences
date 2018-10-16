using System;
using System.Collections;

namespace NumberSequences.NumberSequencesGenerator
{
    //public delegate void EmptySequenceHandler();

    public interface ISequenceGenerator
    {
        event EventHandler DoNotHaveElementsInSequence;

        int StartValue
        {
            get;
        }

        int BoundaryValue
        {
            get;
        }

        bool IsInitialized
        {
            get;
        }

        void Initialize(int startValue, int boundaryValue);

        void Initialize(int boundaryValue);

        IEnumerator GetEnumerator();
    }
}
