using System;
using System.Collections.Generic;
using System.Linq;

namespace Taviloglu.MilliPiyango.ApiClient.SayisalLoto
{
    public class SayisalLotoGuess : LotoGuess
    {
        public SayisalLotoGuess(List<int> numbers) : base(numbers)
        {
            if (numbers.Any(n => n < 1 || n > 49))
            {
                throw new ArgumentOutOfRangeException(nameof(numbers), "numbers must be between 1 and 49");
            }
        }
    }
}
