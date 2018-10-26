using System;
using System.Collections.Generic;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public class NumberGuess
    {
        public NumberGuess(List<int> numbers)
        {
            Numbers = numbers ?? throw new ArgumentNullException(nameof(numbers));
        }

        public List<int> Numbers { get; set; }
    }
}
