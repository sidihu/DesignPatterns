using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public abstract class Charactor
    {
        //Fields
        protected char _symbol;

        protected int _width;

        protected int _height;

        protected int _ascent;

        protected int _descent;

        protected int _pointSize;

        //Method
        public abstract void SetPointSize(int size);
        public abstract void Display();
    }
}
