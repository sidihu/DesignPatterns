using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    //适用性：
    //1．为一个复杂子系统提供一个简单接口。
    //2．提高子系统的独立性。
    //3．在层次化结构中，可以使用Facade模式定义系统中每一层的入口。
    public class FacadePatternDemo
    {
        public void Test()
        {
            Mortgage mortgage = new Mortgage();
            Customer customer = new Customer();
            customer.Name = "sidihu";
            mortgage.IsEligible(customer, 10000);
            Console.ReadLine();
        }

    }
}
