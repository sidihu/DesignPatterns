using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    [Serializable]
    public abstract class NormalActor
    {
        public int i;
        public int[] array;
        public abstract NormalActor ShallowClone();

        public abstract NormalActor DeepClone();
    }
}
