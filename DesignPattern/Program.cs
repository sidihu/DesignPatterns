using System;
using Singleton;
using FactoryMethod;
using PrototypePattern;
using BuilderPattern;
using AbstractFactoryPattern;
using AdapterPattern;
using BridgePattern;
using DecoratorPattern;
using GraphicsPattern;
using FacadePattern;
using FlyweightPattern;
using ProxyPattern;
using TemplateMethodPattern;
using CommandPattern;
using IIteratorPattern;

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
            //AdapterPatternTest();
            //BridgePatternTest();
            //DecoratorPatternTest();
            //CompositePatternTest();
            //FacadePatternTest();
            //FlyweightPatternTest();
            //ProxyPatternDemo();
            //TemplateMethodPatternDemo();
            //CommandPatternDemo();
            IIteratorPatternDemo();
        }

        private static void IIteratorPatternDemo()
        {
            IIteratorPatternDemo demo = new IIteratorPatternDemo();
            demo.Test();
        }

        private static void CommandPatternDemo()
        {
            CommandPatternDemo demo = new CommandPatternDemo();
            demo.Test();
        }

        private static void TemplateMethodPatternDemo()
        {
            TemplateMethodPatternDemo demo = new TemplateMethodPatternDemo();
            demo.Test();
        }
        private static void ProxyPatternDemo()
        {
            ProxyPatternDemo demo = new ProxyPattern.ProxyPatternDemo();
            demo.Test();

        }

        private static void FlyweightPatternTest()
        {
            FlyweightPatternDemo demo = new FlyweightPatternDemo();
            demo.Test();
        }

        private static void FacadePatternTest()
        {
            FacadePatternDemo demo = new FacadePatternDemo();
            demo.Test();
        }

        private static void CompositePatternTest()
        {
            CompositePatternDemo demo = new CompositePatternDemo();
            demo.Test();
        }

        private static void DecoratorPatternTest()
        {
            DecoratorPatternDemo demo = new DecoratorPatternDemo();
            demo.Test();
        }

        private static void BridgePatternTest()
        {
            BridgePatternDemo demo = new BridgePatternDemo();
            demo.Test();
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
