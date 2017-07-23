using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class DataAccessB : DataAccessObject
    {
        public override void Select()
        {
            Console.WriteLine($"{this.GetType().Name} Select");
        }

        public override void Display()
        {
            Console.WriteLine($"{this.GetType().Name} Display");
        }
    }
}
