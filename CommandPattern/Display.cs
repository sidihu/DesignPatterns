using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Display:Command
    {
        public Display(Document doc) : base(doc) { }

        public override void Excute()
        {
            Console.WriteLine("Display");
        }
    }
}
