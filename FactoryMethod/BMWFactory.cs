using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class BMWFactory:CarFactory
    {
        public override Car CreateCar()
        {

            return new BMW();
        }
    }
}
