using System;
using Taviloglu.MilliPiyango.ApiClient.SuperLoto;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public partial class MilliPiyangoApiClient : ISuperLotoClient
    {
        public ISuperLotoClient SuperLoto { get { return (ISuperLotoClient)this; } }

        decimal ISuperLotoClient.GetPrize(LotoResult result, SuperLotoGuess guess)
        {
            return GetLotoPrize(result, guess);
        }

        decimal ISuperLotoClient.GetPrize(DateTime drawDate, SuperLotoGuess guess)
        {
            var result = GetResult<LotoResult>(drawDate, "superloto", "");
            return GetLotoPrize(result, guess);
        }

        LotoResult ISuperLotoClient.GetResult(DateTime drawDate, string savePath)
        {
            return GetResult<LotoResult>(drawDate, "superloto", "", savePath);
        }
    }
}
