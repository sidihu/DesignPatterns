using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class Brush
    {
        protected string color;
        public abstract void Paint();
        public Brush() { }
        public Brush(Color c) { this.color = c.color; }//实例化子类时构造函数初始化Color
        public void SetColr(Color c)
        {
            color = c.color;
        }
    }
}
