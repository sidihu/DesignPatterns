using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public abstract class Command
    {
        Document documnet;

        public Command(Document doc)
        {
            this.documnet = doc;
        }

        public abstract void Excute();
    }
}
