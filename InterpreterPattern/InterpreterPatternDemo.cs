using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class InterpreterPatternDemo
    {
        //适用性：
        //1.当有一个语言需要解释执行，并且你可将该语言中的句子表示为一个抽象语法树时，可使用解释器模式。
        //而当存在以下情况时该模式效果最好：
        //2.该文法简单对于复杂的文法，文法的类层次变得庞大而无法管理。此时语法分析程序生成器这样的工具是更好的选择。它们无需构建抽象语法树即可解释表达工，这样可以节省空间而且还可能节省时间。
        //3.效率不是一个关键问题最高效的解释器通常不是通过直接解释语法分析树实现的，而是首先将它们转换成另一种
        //形式。例如：正则表达式通常被转换成状态机。但即使在这种情况下，转换器仍可用解释器模式实现，该模式仍
        //是有用的。
        public void Test()
        {
            string roman = "五千四百三十二"; //5432
            Context context = new Context(roman);

            //Build the 'parse tree'
            ArrayList tree = new ArrayList();
            tree.Add(new OneExpression());
            tree.Add(new TenExpression());
            tree.Add(new HundredExpression());
            tree.Add(new ThousandExpression());

            //Interpret
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }
            Console.WriteLine("{0} = {1}", roman, context.Data);
            //Wait for user
            Console.Read();
        }
    }
}
