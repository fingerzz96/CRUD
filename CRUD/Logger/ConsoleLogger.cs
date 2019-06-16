using System;
using System.Windows.Forms.VisualStyles;

namespace CRUD.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string log)
        {
            System.Diagnostics.Debug.WriteLine(log); 
        }
    }
}