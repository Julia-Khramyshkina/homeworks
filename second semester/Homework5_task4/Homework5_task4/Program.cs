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

            eventLoop.LeftHandler += (sender, eventArgs) => action.Movement(sender, eventArgs);
            eventLoop.RightHandler += (sender, eventArgs) => action.Movement(sender, eventArgs); 
            eventLoop.UpHandler += (sender, eventArgs) => action.Movement(sender, eventArgs); 
            eventLoop.DownHandler += (sender, eventArgs) => action.Movement(sender, eventArgs); 

            eventLoop.Run();
        }
    }
}
