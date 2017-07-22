using System;
using Singleton;
using FactoryMethod;
using PrototypePattern;
using BuilderPattern;
using AbstractFactoryPattern;
using AdapterPattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //SingletonTest();
            //FactoryMethod();
            //PropertyDemo();
            //BuilderPattern();
            //AbstractFactoryPatternTest();
            AdapterPatternTest();
        }

        private static void AdapterPatternTest()
        {
            AdapterPatternDemo demo = new AdapterPatternDemo();
            demo.Test();

        }

        private static void AbstractFactoryPatternTest()
        {
            AbstractFactory factory = new FactoryA();
            AbstractFactoryPatternDemo demo = new AbstractFactoryPatternDemo(factory);
            demo.Run();
            
        }

        static void BuilderPattern()
        {
            BuilderPatternDemo demo = new BuilderPatternDemo();
            demo.test();
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
