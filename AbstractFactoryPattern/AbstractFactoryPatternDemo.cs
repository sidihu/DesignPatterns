using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    //适用性：
    //1.一个系统要独立于它的产品的创建、组合和表示时。
    //2.一个系统要由多个产品系统中的一个来配置时。
    //3.当你要强调一系列相关的产品对象的设计以便进行联合使用时。
    //4.当你提供一个产品类库，而只想显示它们的接口不是实现时。
    public class AbstractFactoryPatternDemo
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;

        public  AbstractFactoryPatternDemo(AbstractFactory factory)
        {
            abstractProductA = factory.createAbstractProductA();
            abstractProductB = factory.createAbstractProductB();
        }

        public void Run()
        {
            abstractProductA.Interact(abstractProductB);
            abstractProductB.Interact(abstractProductA);
            Console.ReadLine();
        }


    }
}
