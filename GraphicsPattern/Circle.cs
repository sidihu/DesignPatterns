using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsPattern
{
    public class Circle : Graphics
    {
        public Circle(string name) : base(name)
        { }

        public override void Draw()
        {
            Console.WriteLine($"{this.GetType().Name} Draw a {this.Name}");
        }
    }
}
