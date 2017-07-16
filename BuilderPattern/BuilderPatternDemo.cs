using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class BuilderPatternDemo
    {
        //适用性：
        //1.当创建复杂对象的算法应该独立于该对象的组成部分以及它们的装配方式时。
        //2.当构造过程必须允许被构造的对象有不同的表示时。
        public  void test()
        {
            Builder builder = new HouseBuilder();
            Designer designer = new Designer();
            designer.Commond(builder);
            House house = builder.GetHouse();
            house.Show();
        }
    }
}
