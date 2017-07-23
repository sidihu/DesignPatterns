using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class DocumentInvoker
    {
        Command display;
        Command undo;
        Command redo;

        public DocumentInvoker(Command display, Command undo, Command redo)
        {
            this.display = display;
            this.undo = undo;
            this.redo = redo;
        }

        public void Display()
        {
            display.Excute();
        }

        public void Undo()
        {
            undo.Excute();
        }

        public void Redo()
        {
            redo.Excute();
        }
    }
}
