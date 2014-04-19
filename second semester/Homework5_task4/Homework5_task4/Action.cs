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



        public void MovementLeft(object sender, EventArgs args)
        {
             if (Console.CursorLeft - 1 < 0)
                 throw new Exception("going beyond");
             Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }

        public void MovementRight(object sender, EventArgs args)
        {
            if (Console.CursorLeft > Console.WindowWidth)
                throw new Exception("going beyond");
            Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
        }

        public void MovementUp(object sender, EventArgs args)
        {
            if (Console.CursorTop - 1 < 0)
                throw new Exception("going beyond");
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
        }

        public void MovementDown(object sender, EventArgs args)
        { 
            if (Console.CursorTop > Console.WindowWidth)
                throw new Exception("going beyond");
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
        }
    }
}
