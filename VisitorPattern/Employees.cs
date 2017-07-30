using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Employees
    {
        private ArrayList employees = new ArrayList();
 
     public void Attach(Employee employee)
     {
       employees.Add(employee);
     }
 
     public void Detach(Employee employee)
     {
       employees.Remove(employee);
     }
 
     public void Accept(IVisitor visitor)
     {
       foreach (Employee e in employees)
       {
         e.Accept(visitor);
       }
       Console.WriteLine();
     }
    }
}
