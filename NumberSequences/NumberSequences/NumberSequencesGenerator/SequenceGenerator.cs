using System;
using System.Collections;

namespace NumberSequences.NumberSequencesGenerator
{
    public abstract class SequenceGenerator : ISequenceGenerator
    {
        protected const int NOT_INITIALIZED = -1;

        public SequenceGenerator()
        {
            this.StartValue = NOT_INITIALIZED;
            this.BoundaryValue = NOT_INITIALIZED;
            this.IsInitialized = false;
            this.MinimumValue = 0;
        }

        public abstract event EventHandler DoNotHaveElementsInSequence;

        public int StartValue
        {
            get;
            protected set;
        }

        public int BoundaryValue
        {
            get;
            protected set;
        }

        public bool IsInitialized
        {
            get;
            protected set;
        }

        public int MinimumValue
        {
            get;
            protected set;
        }

        public void Initialize(int startValue, int boundaryValue)
        {
            if (boundaryValue < startValue)
            {
                throw new ArgumentException("Boundary value of sequence can not be less than "
                    + "start value of sequence!");
            }

            if (boundaryValue < this.MinimumValue || startValue < this.MinimumValue)
            {
                throw new ArgumentException("Invalid value of arguments! "
                    + "Can`t build sequence with such values! "
                    + $"Sequence of requested type starts with {this.MinimumValue}!");
            }

            this.StartValue = startValue;
            this.BoundaryValue = boundaryValue;
            this.IsInitialized = true;
        }

        public void Initialize(int boundaryValue)
        {
            this.Initialize(this.MinimumValue, boundaryValue);
        }

        public abstract IEnumerator GetEnumerator();
    }
}
