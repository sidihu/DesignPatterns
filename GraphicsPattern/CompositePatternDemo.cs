using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsPattern
{
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
