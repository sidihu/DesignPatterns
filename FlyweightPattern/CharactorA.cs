using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class CharactorA : Charactor
    {
        // Constructor 
        public CharactorA()
        {
            this._symbol = 'A';
            this._height = 100;
            this._width = 120;
            this._ascent = 70;
            this._descent = 0;
        }

        //Method
        public override void SetPointSize(int size)
        {
            this._pointSize = size;
        }

        public override void Display()
        {
            Console.WriteLine(this._symbol +
              "  pointsize:" + this._pointSize);
        }
    }
}
