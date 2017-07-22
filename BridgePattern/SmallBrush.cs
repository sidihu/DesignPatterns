using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class SmallBrush : Brush
    {
        public SmallBrush(Color c):base(c)
        { }
        public override void Paint()
        {
            Console.Write($"{this.GetType().Name} paint with {this.color}\n");
            Console.ReadLine();
        }
    }
}
