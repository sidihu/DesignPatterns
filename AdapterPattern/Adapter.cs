using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    //对象适配器
    public class Adapter:IStack
    {
        ArrayList arrayList;

        public Adapter()
        {
            arrayList = new ArrayList();
        }

        public void Push(object o)
        {
            arrayList.Add(o);
        }

        public void Pop()
        {
            arrayList.RemoveAt(arrayList.Count-1);
        }

        public object Peek()
        {
            return arrayList[arrayList.Count-1];
        }

        public int Count()
        {
            return arrayList.Count;
        }
    }
}
