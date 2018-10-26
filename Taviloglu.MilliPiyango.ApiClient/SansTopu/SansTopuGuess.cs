using System;
using System.Collections.Generic;
using System.Linq;

namespace Taviloglu.MilliPiyango.ApiClient.SansTopu
{
    public class SansTopuGuess
    {
        public SansTopuGuess(List<int> numbers, int plusOne)
        {
            if (numbers == null) throw new ArgumentNullException(nameof(numbers));

            if (numbers.Count != 5) throw new ArgumentException("numbers count must be five", nameof(numbers));

            if (numbers.Any(n => n > 34 || n < 1)) throw new ArgumentOutOfRangeException(nameof(numbers), "numbers must be between 1 and 34");

            if (plusOne < 1 || plusOne > 14) throw new ArgumentOutOfRangeException(nameof(plusOne), "plusOne must be between 1 and 14");

            Numbers = numbers;
            PlusOne = plusOne;
        }

        public List<int> Numbers { get; private set; }
        public int PlusOne { get; private set; }
    }
}
