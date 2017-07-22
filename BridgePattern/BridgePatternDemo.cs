using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
      //适用性：   
      //1．如果一个系统需要在构件的抽象化角色和具体化角色之间增加更多的灵活性，避免在两个层次之间建立静态的联系。
      //2．设计要求实现化角色的任何改变不应当影响客户端，或者说实现化角色的改变对客户端是完全透明的。
      //3 ．一个构件有多于一个的抽象化角色和实现化角色，系统需要它们之间进行动态耦合。
      //4 ．虽然在系统中使用继承是没有问题的，但是由于抽象化角色和具体化角色需要独立变化，设计要求需要独立管理这两者。
    public class BridgePatternDemo
    {
        public void Test()
        {
            Color c = new Red();
            Brush smallBrush = new SmallBrush(c);//构造函数中初始化颜色
            smallBrush.Paint();

            c = new Green();
            Brush bigBrush = new BigBrush();
            bigBrush.SetColr(c);//创建对象后设置颜色
            bigBrush.Paint();
        }
    }
}
