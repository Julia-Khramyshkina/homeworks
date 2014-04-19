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

            eventLoop.LeftHandler += (sender, eventArgs) => actionLeft.MovementLeft(sender, eventArgs);
            eventLoop.RightHandler += (sender, eventArgs) => actionRight.MovementRight(sender, eventArgs); 
            eventLoop.UpHandler += (sender, eventArgs) => actionUp.MovementUp(sender, eventArgs); 
            eventLoop.DownHandler += (sender, eventArgs) => actionDown.MovementDown(sender, eventArgs); 

            eventLoop.Run();
        }
    }
}
