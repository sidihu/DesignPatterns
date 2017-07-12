using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingleThread_Singleton
    {
        private SingleThread_Singleton() { }
        private static SingleThread_Singleton instance = null;
        public string want="SingleThread_Singleton wanted";
        public static SingleThread_Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new SingleThread_Singleton();
                return instance;
            }
        }
    }
}
