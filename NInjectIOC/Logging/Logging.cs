using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInjectIOC
{
    class Logging : ILogging
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
