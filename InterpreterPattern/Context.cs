using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class Context
    {
        private string statement;
        private int data;

        //Constructor
        public Context(string statement)
        {
            this.statement = statement;
        }
        //Properties
        public string Statement
        {
            get { return statement; }
            set { statement = value; }
        }
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
