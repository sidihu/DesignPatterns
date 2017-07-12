using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Car
    {
        public abstract void StartUp();
        public abstract void Run();
        public abstract void Stop();
    }
}
