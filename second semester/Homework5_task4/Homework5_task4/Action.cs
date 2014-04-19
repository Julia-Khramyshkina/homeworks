using System;

namespace Homework5_task4
{
    /// <summary>
    /// class -- The Action
    /// </summary>
    public class Action
    {
        private int origRow;
        private int origCol;

        public Action(int value1, int value2)
        {
            this.origRow = value1;
            this.origCol = value2;
        }

        /// <summary>
        /// Move left.
        /// </summary>
        /// <param name="sender"> This object.</param>
        /// <param name="args"> This params.</param>
        public void MovementLeft(object sender, EventArgs args)
        {
             if (Console.CursorLeft - 1 < 0)
                 throw new Exception("going beyond");
             Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }

        /// <summary>
        /// Move right.
        /// </summary>
        /// <param name="sender"> This object.</param>
        /// <param name="args"> This params.</param>
        public void MovementRight(object sender, EventArgs args)
        {
            if (Console.CursorLeft > Console.WindowWidth)
                throw new Exception("going beyond");
            Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
        }

        /// <summary>
        /// Move up.
        /// </summary>
        /// <param name="sender"> This object.</param>
        /// <param name="args"> This params.</param>
        public void MovementUp(object sender, EventArgs args)
        {
            if (Console.CursorTop - 1 < 0)
                throw new Exception("going beyond");
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
        }

        /// <summary>
        /// Move down.
        /// </summary>
        /// <param name="sender"> This object.</param>
        /// <param name="args"> This params.</param>
        public void MovementDown(object sender, EventArgs args)
        { 
            if (Console.CursorTop > Console.WindowWidth)
                throw new Exception("going beyond");
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
        }
    }
}
