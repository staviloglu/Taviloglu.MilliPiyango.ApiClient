using System;
using System.Collections.Generic;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public abstract class SixNumberGuess : NumberGuess
    {
        public SixNumberGuess(List<int> numbers) : base(numbers)
        {
            if (numbers.Count != 6)
            {
                throw new ArgumentException("numbers count must be six", nameof(numbers));
            }
        }
    }
}
