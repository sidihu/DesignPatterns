using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    //类适配
    public class AdapterV2 : ArrayList, IStack
    {
        public void Push(object o)
        {
            this.Add(o);
        }

        public void Pop()
        {
            this.RemoveAt(this.Count-1);
        }

        public object Peek()
        {
            return this[this.Count - 1];
        }
    }
}
