using System;
using System.Net;

namespace Taviloglu.MilliPiyango.ApiClient
{
    internal static class WebHelper
    {
        public static string DownloadResultJson(DateTime drawDate, string name, string prefix)
        {
            string json = string.Empty;

            using (var webClient = new WebClient())
            {
                json = webClient.DownloadString(
                    $"http://www.mpi.gov.tr/sonuclar/cekilisler/{name}/{prefix}{drawDate:yyyyMMdd}.json");
            }

            return json;
        }
    }
}
