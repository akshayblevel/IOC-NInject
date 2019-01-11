using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NInjectIOC
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var topup = kernel.Get<ITopup>();
            Handler handler = new Handler(topup);
            handler.DoRecharge("9999999999");

            Console.ReadLine();
        }
    }
}
