using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class BMW:Car
    {
        public override void StartUp()
        {
            Console.Write($"BMW StartUp \n");
        }

        public override void Run()
        {
            Console.Write($"BMW Run \n");
        }

        public override void Stop()
        {
            Console.Write($"BMW Stop \n");
        }
    }
}
