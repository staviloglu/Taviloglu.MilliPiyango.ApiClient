using Newtonsoft.Json;
using System;
using System.IO;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public abstract class Client<T>
    {
        protected readonly IResultReader _resultReader;

        public Client(IResultReader resultReader)
        {
            _resultReader = resultReader;
        }

        public T GetResult(DateTime drawDate, string savePath = null)
        {
            if (drawDate == null)
            {
                throw new ArgumentNullException(nameof(drawDate));
            }

            var json = _resultReader.Read(drawDate);

            if (!string.IsNullOrWhiteSpace(savePath))
            {
                File.WriteAllText(savePath, json);
            }

            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
