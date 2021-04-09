using System;
using System.IO;

namespace unitTesting
{
    public class FileProcess
    {
        public bool FileExists(string filename)
        {
            if (string.IsNullOrEmpty(filename))
            {
                throw new ArgumentException("filename");
            }

            return File.Exists(filename);
        }
    }
}
