using System;
using System.Collections.Generic;
using System.Linq;

namespace Taviloglu.MilliPiyango.ApiClient.SuperLoto
{
    public class SuperLotoGuess : LotoGuess
    {
        public SuperLotoGuess(List<int> numbers) :base(numbers)
        {
            if (numbers.Any(n => n < 1 || n > 54))
            {
                throw new ArgumentOutOfRangeException(nameof(numbers), "numbers must be between 1 and 54");
            }
        }
    }
}
