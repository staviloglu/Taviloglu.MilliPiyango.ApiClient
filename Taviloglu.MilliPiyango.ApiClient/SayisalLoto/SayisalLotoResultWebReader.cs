using System;

namespace Taviloglu.MilliPiyango.ApiClient.SayisalLoto
{
    public class SayisalLotoResultWebReader : IResultReader
    {
        public string Read(DateTime drawDate)
        {
            return WebHelper.DownloadResultJson(drawDate, "sayisal", "SAY_");            
        }
    }
}
