using System;
using Taviloglu.MilliPiyango.ApiClient.SayisalLoto;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public partial class MilliPiyangoApiClient : ISayisalLotoClient
    {
        public ISayisalLotoClient SayisalLoto { get { return (ISayisalLotoClient)this; } }

        decimal ISayisalLotoClient.GetPrize(LotoResult result, SayisalLotoGuess guess)
        {
            return GetLotoPrize(result, guess);
        }

        decimal ISayisalLotoClient.GetPrize(DateTime drawDate, SayisalLotoGuess guess)
        {
            var result = GetResult<LotoResult>(drawDate, "sayisal", "SAY_");
            return GetLotoPrize(result, guess);
        }

        LotoResult ISayisalLotoClient.GetResult(DateTime drawDate, string savePath)
        {
            return GetResult<LotoResult>(drawDate, "sayisal", "SAY_", savePath);
        }
    }
}
