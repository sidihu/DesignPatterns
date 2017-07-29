using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class OneExpression : Expression
    {
        public override string GetPostifix()
        {
            return "";
        }
        public override int Multiplier() { return 1; }
        public override int GetLength()
        {
            return 1;
        }
    }
    public class TenExpression : Expression
    {
        public override string GetPostifix()
        {
            return "十";
        }
        public override int Multiplier() { return 10; }
        public override int GetLength()
        {
            return 2;
        }
    }
    public class HundredExpression : Expression
    {
        public override string GetPostifix()
        {
            return "百";
        }
        public override int Multiplier() { return 100; }
        public override int GetLength()
        {
            return 2;
        }
    }
    public class ThousandExpression : Expression
    {
        public override string GetPostifix()
        {
            return "千";
        }
        public override int Multiplier() { return 1000; }
        public override int GetLength()
        {
            return 2;
        }
    }
}
