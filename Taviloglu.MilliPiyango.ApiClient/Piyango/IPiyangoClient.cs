using System;

namespace Taviloglu.MilliPiyango.ApiClient.Piyango
{
    public interface IPiyangoClient
    {
        decimal GetPrize(PiyangoResult result, PiyangoGuess guess);
        PiyangoResult GetResult(DateTime drawDate, string savePath = null);
    }
}
