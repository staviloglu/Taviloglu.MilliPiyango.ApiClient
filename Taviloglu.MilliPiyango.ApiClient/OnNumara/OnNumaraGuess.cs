using System;
using System.Collections.Generic;
using System.Linq;

namespace Taviloglu.MilliPiyango.ApiClient.OnNumara
{
    public class OnNumaraGuess : NumberGuess
    {
        public OnNumaraGuess(List<int> numbers) : base (numbers)
        {
            if (numbers.Count != 10) throw new ArgumentException("numbers count must be ten", nameof(numbers));

            if (numbers.Any(n => n < 1 || n > 80)) throw new ArgumentOutOfRangeException(nameof(numbers), "numbers must be between 1 and 80");

        }
    }
}
