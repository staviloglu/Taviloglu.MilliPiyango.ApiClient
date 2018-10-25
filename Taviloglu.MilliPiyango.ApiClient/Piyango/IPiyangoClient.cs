using System;
using System.Collections.Generic;
using System.Text;

namespace Taviloglu.MilliPiyango.ApiClient.Piyango
{
    public interface IPiyangoClient
    {
        PiyangoResult GetResult(DateTime drawDate, string savePath = null);
        decimal GetPrize(PiyangoResult result, PiyangoGuess guess);
        decimal GetPrize(DateTime drawDate, PiyangoGuess guess);
    }
}
