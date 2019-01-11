using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInjectIOC
{
    class Mobile : ITopup
    {
        public ILogging logging { get; set; }

        public Mobile(ILogging logging)
        {
            this.logging = logging;
        }

        public void DoTopup(string request)
        {
            Console.WriteLine("Mobile Topup is done Successfully.");
            logging.Log(request);
        }
    }
}
