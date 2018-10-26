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

        LotoResult ISuperLotoClient.GetResult(DateTime drawDate, string savePath)
        {
            return GetResult<LotoResult>(drawDate, "superloto", "", savePath);
        }
    }
}
