using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ProxyPatternDemo
    {
        public void Test()
        {
            ProxyMath proxyMath = new ProxyMath();
            double a = proxyMath.Add(3, 4);
            double b = proxyMath.Sub(3, 4);
            double c = proxyMath.Mul(3, 4);
            double d = proxyMath.Dev(3, 4);

            Console.WriteLine($" Add:{a} \n Sub:{b}\n Mul:{c}\n Dev:{d}");
            Console.ReadLine();
        }
    }
}
