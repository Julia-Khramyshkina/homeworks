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
            Action action = new Action(Console.CursorLeft, Console.CursorTop);


            eventLoop.LeftHandler += action.Movement;
            eventLoop.RightHandler += action.Movement;
            eventLoop.UpHandler += action.Movement;
            eventLoop.DownHandler += action.Movement;
 

            eventLoop.LeftHandler += (sender, eventArgs) => Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            eventLoop.RightHandler += (sender, eventArgs) => Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
            eventLoop.UpHandler += (sender, eventArgs) => Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            eventLoop.DownHandler += (sender, eventArgs) => Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);


            eventLoop.Run();
        }
    }
}
