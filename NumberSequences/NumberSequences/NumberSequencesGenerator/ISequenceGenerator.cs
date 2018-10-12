using System;
using System.Collections;

namespace NumberSequences.NumberSequencesGenerator
{
    public interface ISequenceGenerator
    {
        int StartWith
        {
            get;
        }

        int Border
        {
            get;
        }

        bool IsInitialized
        {
            get;
        }

        void Initialize(int border, int startwith);

        void Initialize(int border);

        IEnumerator GetEnumerator();
    }
}
