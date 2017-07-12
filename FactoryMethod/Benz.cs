using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Benz:Car
    {
        public override void StartUp()
        {
            Console.Write($"Benz StartUp \n");
        }

        public override void Run()
        {
            Console.Write($"Benz Run \n"); 
        }

        public override void Stop()
        {
            Console.Write($"Benz Stop \n");
        }
    }
}
