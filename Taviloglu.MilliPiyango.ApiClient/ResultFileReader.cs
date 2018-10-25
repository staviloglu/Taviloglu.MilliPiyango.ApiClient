using System;
using System.IO;

namespace Taviloglu.MilliPiyango.ApiClient
{
    public class ResultFileReader : IResultReader
    {
        private readonly string _directoryPath;
        private readonly string _fileNameFormat;

        public ResultFileReader(string directoryPath, string fileNameFormat)
        {
            _directoryPath = directoryPath;
            _fileNameFormat = fileNameFormat;
        }

        public string Read(DateTime drawDate)
        {
            string filePath = Path.Combine(_directoryPath, string.Format(_fileNameFormat, drawDate));
            return File.ReadAllText(filePath);
        }
    }
}
