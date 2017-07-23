using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    //显然在这个顶级的框架DataAccessObject中给出了固定的轮廓，方法Run()便是模版方法，
    //Template Method模式也由此而得名。而对于Select()和Display()这两个抽象方法则留给具体的子类去实现
    public abstract class DataAccessObject
    {
        private string ConnectString = string.Empty;
        public virtual void CreateConnect()
        {
            Console.WriteLine("CreateConnect");
        }

        public abstract void Select();

        public abstract void Display();

        public virtual void Dispose()
        {
            Console.WriteLine("Dispose");
        }

        public void Run()
        {
            this.CreateConnect();
            this.Select();
            this.Dispose();
            this.Display();
        }
    }
}
