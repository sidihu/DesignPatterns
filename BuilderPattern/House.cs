using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class House
    {
        public string Door { get; set; }
        public string Wall { get; set; }
        public string Window { get; set; }
        public string Floor { get; set; }
        public string HouseCeiling { get; set; }
        public void Show()
        {
            Console.Write($"I have {Door}\n");
            Console.Write($"I have {Wall}\n");
            Console.Write($"I have {Window}\n");
            Console.Write($"I have {Floor}\n");
            Console.Write($"I have {HouseCeiling}\n");
            Console.ReadLine();
        }

    }
}
