using System;
using System.IO;

namespace CRUD.Logger
{
    public class FileLogger : ILogger
    {
        public void Log(string log)
        {
            string path = "logger.txt";

            if (String.IsNullOrWhiteSpace(path) == false)
            {
                try
                {
                    File.AppendAllText(path, log + Environment.NewLine);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}