using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Static_Singleton
    {
        //如果类成员有private修饰符，就不允许在类范围以外访问这个类成员。
        //对类构造函数应用private修饰符时，则禁止外部类创建该类的实例。
        //使用私有构造函数的类不会被继承，而且也不能被继承。其次，私有构造函数只能禁止外部类对该类进行实例化，却不能禁止在该类内部创建实例。
        private Static_Singleton() { }
        public string want = "Static_Singleton wanted";
        public static readonly Static_Singleton Instance = new Static_Singleton();
    }
}
