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

        //public void FunctionForException(ConsoleKey key)
        //{
        //    if (key == ConsoleKey.LeftArrow)
        //    {
        //        if (Console.CursorLeft - 1 < 0)
        //            throw new Exception("going beyond");
        //    }

        //    if (key == ConsoleKey.RightArrow)
        //    {
        //        if (Console.CursorLeft > Console.WindowWidth)
        //            throw new Exception("going beyond");
        //    }

        //    if (key == ConsoleKey.UpArrow)
        //    {
        //        if (Console.CursorTop - 1 < 0)
        //            throw new Exception("going beyond");
        //    }

        //    if (key == ConsoleKey.DownArrow)
        //    {
        //        if (Console.CursorTop > Console.WindowWidth)
        //            throw new Exception("going beyond");
        //    }
        //}

        public void Movement(object sender, EventArgs args)
        {
            //ConsoleKey key = ????;
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    {
                        if (Console.CursorLeft - 1 < 0)
                            throw new Exception("going beyond");
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        break;

                    }

                case ConsoleKey.RightArrow:
                    {
                        if (Console.CursorLeft > Console.WindowWidth)
                            throw new Exception("going beyond");
                        Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
                        break;
                    }

                case ConsoleKey.UpArrow:
                    {
                        if (Console.CursorTop - 1 < 0)
                            throw new Exception("going beyond");
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                        break;
                    }

                case ConsoleKey.DownArrow:
                    {
                        if (Console.CursorTop > Console.WindowWidth)
                            throw new Exception("going beyond");
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
                        break;
                    }

                //Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);     
            }
        }
    }
}
