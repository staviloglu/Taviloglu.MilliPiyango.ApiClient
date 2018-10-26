using System;
using Taviloglu.MilliPiyango.ApiClient.SansTopu;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public interface ISansTopuClient
    {
        decimal GetPrize(LotoResult result, SansTopuGuess guess);
        LotoResult GetResult(DateTime drawDate, string savePath = null);
    }
}
