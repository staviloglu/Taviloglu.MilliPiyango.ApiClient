using System;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public interface IResultReader
    {
        string Read(DateTime drawDate);
    }
}
