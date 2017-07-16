using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;
using FactoryMethod;
using PrototypePattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //SingletonTest();
            //FactoryMethod();
            PropertyDemo();
        }

        static void PropertyDemo()
        {
            PrototypePatternDemo demo = new PrototypePatternDemo();
            demo.test();

        }

        static void SingletonTest()
        {
            var want1 = MultiThread_Singleton.Instance.want;
            var want2 = Static_Singleton.Instance.want;
            var want3 = SingleThread_Singleton.Instance.want;
            Console.Write($"I am：{want1}\n");
            Console.Write($"I am：{want2}\n");
            Console.Write($"I am：{want3}\n");
            Console.ReadLine();
        }

        static void FactoryMethod()
        {
            FactoryMethodDemo f = new FactoryMethodDemo();
            f.test();
        }
    }
}
