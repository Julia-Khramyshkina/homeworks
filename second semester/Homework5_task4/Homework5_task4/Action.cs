using System;

namespace Homework5_task4
{
    public class Action
    {
        private int origRow;
        private int origCol;
        public Action(int value1, int value2)
        {
            this.origRow = value1;
            this.origCol = value2;
        }
        public void Movement(object sender, EventArgs args)
        {
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);     
        }
    }
}
