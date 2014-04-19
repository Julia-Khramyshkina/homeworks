using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventLoop = new EventLoop();
            Console.Clear();
            Action actionLeft = new Action(Console.CursorLeft, Console.CursorTop);
            Action actionRight = new Action(Console.CursorLeft, Console.CursorTop);
            Action actionUp = new Action(Console.CursorLeft, Console.CursorTop);
            Action actionDown = new Action(Console.CursorLeft, Console.CursorTop);

            eventLoop.LeftHandler += actionLeft.MovementLeft;
            eventLoop.RightHandler += actionRight.MovementRight;
            eventLoop.UpHandler += actionUp.MovementUp;
            eventLoop.DownHandler += actionDown.MovementDown;

            eventLoop.Run();
        }
    }
}
