using System;

namespace Taviloglu.MilliPiyango.ApiClient.SuperLoto
{
    public class SuperLotoResultWebReader : IResultReader
    {
        public string Read(DateTime drawDate)
        {
            return WebHelper.DownloadResultJson(drawDate, "superloto", "");            
        }
    }
}
