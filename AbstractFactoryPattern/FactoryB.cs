using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class FactoryB : AbstractFactory
    {
        public override AbstractProductA createAbstractProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB createAbstractProductB()
        {
            return new ProductB2();
        }
    }
}
