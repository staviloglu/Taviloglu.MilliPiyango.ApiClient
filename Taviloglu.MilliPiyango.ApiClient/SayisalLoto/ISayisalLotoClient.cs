﻿using System;
using Taviloglu.MilliPiyango.ApiClient.SayisalLoto;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public interface ISayisalLotoClient
    {
        decimal GetPrize(LotoResult result, SayisalLotoGuess guess);
        decimal GetPrize(DateTime drawDate, SayisalLotoGuess guess);
        LotoResult GetResult(DateTime drawDate, string savePath = null);
    }
}
