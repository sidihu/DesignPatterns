using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ProductA1:AbstractProductA
    {
        public override void Interact(AbstractProductB b)
        {
            Console.Write($"{this.GetType().Name} interact with { b.GetType().Name}\n");
        }
    }
}
