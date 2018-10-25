using System;

namespace Taviloglu.MilliPiyango.ApiClient.SayisalLoto
{
    public class SayisalLotoClient : LotoClient
    {
        /// <summary>
        /// initializes a new instance of the class SayisalLotoClient
        /// </summary>
        /// <param name="resultReader"></param>
        public SayisalLotoClient(IResultReader resultReader) : base(resultReader) { }

        /// <summary>
        /// initializes a new instance of the class SayisalLotoClient with SayisalLotoResultWebReader
        /// </summary>
        public SayisalLotoClient() : base(new SayisalLotoResultWebReader()) { }

    }
}
