using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Redo : Command
    {
        public Redo(Document doc) : base(doc) { }

        public override void Excute()
        {
            Console.WriteLine("Redo");
        }
    }
}
