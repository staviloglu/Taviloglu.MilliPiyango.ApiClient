using System;

namespace Taviloglu.MilliPiyango.ApiClient.Piyango
{
    public class PiyangoResultWebReader : IResultReader
    {
        public string Read(DateTime drawDate)
        {
            return WebHelper.DownloadResultJson(drawDate, "piyango", "");
        }
    }
}
