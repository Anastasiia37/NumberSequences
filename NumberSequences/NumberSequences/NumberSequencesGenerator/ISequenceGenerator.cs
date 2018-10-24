// <copyright file="ISequenceGenerator.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using System.Collections;

namespace NumberSequences.NumberSequencesGenerator
{
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