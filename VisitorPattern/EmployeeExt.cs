using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Clerk : Employee
    {
        // Constructor
        public Clerk() : base("Hank", 25000.0, 14)
        {
        }
    }

    class Director : Employee
    {
        // Constructor
        public Director() : base("Elly", 35000.0, 16)
        {
        }
    }

    class President : Employee
    {
        // Constructor
        public President() : base("Dick", 45000.0, 21)
        {
        }
    }
}
