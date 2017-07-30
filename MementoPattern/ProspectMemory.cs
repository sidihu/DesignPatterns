using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class ProspectMemory
    {
        private Memento memento;

        //Property
        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
