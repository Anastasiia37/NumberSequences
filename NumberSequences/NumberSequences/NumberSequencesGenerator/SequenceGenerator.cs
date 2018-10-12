using System;
using System.Collections;

namespace NumberSequences.NumberSequencesGenerator
{
    public abstract class SequenceGenerator : ISequenceGenerator
    {
        protected const int NOT_INITIALIZED = -1;
        protected int minimumValue = 0;

        public SequenceGenerator()
        {
            this.StartWith = NOT_INITIALIZED;
            this.Border = NOT_INITIALIZED;
            this.IsInitialized = false;
        }

        public int StartWith
        {
            get;
            protected set;
        }

        public int Border
        {
            get;
            protected set;
        }

        public bool IsInitialized
        {
            get;
            protected set;
        }

        public void Initialize(int border, int startWith)
        {
            if (border < startWith)
            {
                throw new ArgumentException("Start value of sequence can not be less than "
                    + "end value of sequence!");
            }

            if (border < this.minimumValue || startWith < this.minimumValue)
            {
                throw new ArgumentException("Invalid value of arguments! "
                    + "Can`t build sequence with such values! "
                    + $"Sequence of requested type starts with {this.minimumValue}!");
            }

            this.StartWith = startWith;
            this.Border = border;
            this.IsInitialized = true;
        }

        public void Initialize(int border)
        {
            this.Initialize(border, this.minimumValue);
        }

        public abstract IEnumerator GetEnumerator();
    }
}
