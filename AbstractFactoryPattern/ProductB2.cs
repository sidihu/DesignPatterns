using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.Write($"{this.GetType().Name} interact with { a.GetType().Name}\n");
        }
    }
}
