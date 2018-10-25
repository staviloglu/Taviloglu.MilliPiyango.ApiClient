using System;
using System.Collections.Generic;
using System.Linq;

namespace Taviloglu.MilliPiyango.ApiClient.Piyango
{
    public class PiyangoGuess
    {
        public PiyangoGuess(List<int> numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            if (numbers.Count != 6)
            {
                throw new ArgumentException("numbers count must be six", nameof(numbers));
            }

            if (numbers.Any(n => n < 0 || n > 9))
            {
                throw new ArgumentOutOfRangeException(nameof(numbers), "numbers must be between 0 and 9");
            }

            Numbers = numbers;
        }

        public List<int> Numbers { get; private set; }
    }
}
