using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInjectIOC
{
    class Handler
    {
        public ITopup topup { get; private set; }
        public Handler(ITopup topup)
        {
            this.topup = topup;
        }

        public void DoRecharge(string request)
        {
            topup.DoTopup(request);
        }
    }
}
