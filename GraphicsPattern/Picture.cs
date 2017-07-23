using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsPattern
{
    public class Picture : Graphics
    {
        protected ArrayList arrayList = new ArrayList();

        public Picture(string name):base(name)
        {

        }

        public override void Draw()
        {
            foreach(Graphics g in arrayList)
            {
                g.Draw();
            }
        }

        public void Add(Graphics graphics)
        {
            arrayList.Add(graphics);
        }

        public void Remove(Graphics graphics)
        {
            arrayList.Remove(graphics);
        }
    }
}
