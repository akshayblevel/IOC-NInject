using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInjectIOC
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ITopup>().To<Mobile>();
            Bind<ILogging>().To<Logging>();
        }
    }
}
