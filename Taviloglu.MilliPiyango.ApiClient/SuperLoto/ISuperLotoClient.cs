using System;
using Taviloglu.MilliPiyango.ApiClient.SuperLoto;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public interface ISuperLotoClient
    {

        decimal GetPrize(LotoResult result, SuperLotoGuess guess);
        LotoResult GetResult(DateTime drawDate, string savePath = null);
    }
}