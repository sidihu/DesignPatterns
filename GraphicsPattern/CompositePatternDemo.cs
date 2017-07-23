using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsPattern
{
    //适用性：   
    //1．你想表示对象的部分-整体层次结构
    //2．你希望用户忽略组合对象与单个对象的不同，用户将统一地使用组合结构中的所有对象。
    public class CompositePatternDemo
    {
        public void Test()
        {
            Picture pic = new Picture("Root");
            Graphics line = new Line(" LineA");
            pic.Add(line);
            Graphics circle = new Circle(" CircleA");
            pic.Add(circle);
            Graphics rectangle = new Rectangle(" RectangleA");
            pic.Add(rectangle);
            pic.Draw();

            pic.Remove(circle);
            pic.Draw();
            Console.ReadLine();
        }
    }
}
