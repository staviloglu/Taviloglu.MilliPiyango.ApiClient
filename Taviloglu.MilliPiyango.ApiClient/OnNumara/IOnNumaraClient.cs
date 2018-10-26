using System;
using Taviloglu.MilliPiyango.ApiClient.OnNumara;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public interface IOnNumaraClient
    {
        decimal GetPrize(LotoResult result, OnNumaraGuess guess);
        LotoResult GetResult(DateTime drawDate, string savePath = null);
    }
}
