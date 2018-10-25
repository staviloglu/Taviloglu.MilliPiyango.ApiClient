using System;

namespace Taviloglu.MilliPiyango.ApiClient.SuperLoto
{
    public class SuperLotoClient : LotoClient
    {
        /// <summary>
        /// initializes a new instance of the class SayisalLotoClient
        /// </summary>
        /// <param name="resultReader"></param>
        public SuperLotoClient(IResultReader resultReader) : base(resultReader) { }

        /// <summary>
        /// initializes a new instance of the class SayisalLotoClient with SayisalLotoResultWebReader
        /// </summary>
        public SuperLotoClient() : base(new SuperLotoResultWebReader()) { }


    }
}
