using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    //备忘录模式
    //适用性：
    //1.必须保存一个对象某一个时刻的(部分)状态，这样以后需要时它才能恢复到先前的状态。
    //2.如果一个用接口来让其它对象直接得到这些状态，将会暴露对象的实现细节并破坏对象的封装性。
    public class MementoPatternDemo
    {
        public void Test()
        {
            SalesProspect s = new SalesProspect();
            s.Name = "xiaoming";
            s.Phone = "(010)65236523";
            s.Budget = 28000.0;

            //Store internal state
            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();

            //Continue changing originator
            s.Name = "deke";
            s.Phone = "(029)85423657";
            s.Budget = 80000.0;

            //Restore saved state 
            s.RestoreMemento(m.Memento);

            //Wait for user 
            Console.Read();
        }
    }
}
