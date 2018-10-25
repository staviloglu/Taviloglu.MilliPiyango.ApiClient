using System;
using System.Collections.Generic;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public abstract class LotoGuess
    {
        public LotoGuess(List<int> numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            if (numbers.Count != 6)
            {
                throw new ArgumentException("numbers count must be six", nameof(numbers));
            }

            Numbers = numbers;
        }

        public List<int> Numbers { get; protected set; }
    }
}
