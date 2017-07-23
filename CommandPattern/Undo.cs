using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Undo : Command
    {
        public Undo(Document doc) : base(doc) { }

        public override void Excute()
        {
            Console.WriteLine("Undo");
        }
    }
}
