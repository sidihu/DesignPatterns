using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    interface IMath
    {
        double Add(double x, double y);

        double Sub(double x, double y);

        double Mul(double x, double y);

        double Dev(double x, double y);
    }
}
