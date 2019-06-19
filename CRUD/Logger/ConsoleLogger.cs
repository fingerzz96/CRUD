using System.Diagnostics;

namespace CRUD.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string log) { Debug.WriteLine(log); }
    }
}