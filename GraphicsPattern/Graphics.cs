using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsPattern
{
    public abstract class Graphics
    {
        protected string Name;

        public Graphics(string name)
        {
            this.Name = name;
        }

        public abstract void Draw();
    }
}
