using System;
using System.Collections.Generic;
using System.Linq;

namespace Taviloglu.MilliPiyango.ApiClient.Piyango
{
    public class PiyangoGuess : SixNumberGuess
    {
        public PiyangoGuess(List<int> numbers) : base(numbers)
        {
            if (numbers.Any(n => n < 0 || n > 9))
            {
                throw new ArgumentOutOfRangeException(nameof(numbers), "numbers must be between 0 and 9");
            }
        }
    }
}
