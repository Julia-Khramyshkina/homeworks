using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_task4
{
    public class EventLoop
    {
        public event EventHandler<EventArgs> LeftHandler = (sender, args) => { };
        public event EventHandler<EventArgs> RightHandler = (sender, args) => { };
        public event EventHandler<EventArgs> UpHandler = (sender, args) => { };
        public event EventHandler<EventArgs> DownHandler = (sender, args) => { };

        public void Run()
        {
            try
            {
                while (true)
                {
                    var key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            {
                                if (Console.CursorLeft - 1 < 0)
                                    throw new Exception("going beyond");
                                LeftHandler(this, EventArgs.Empty);
                                break;
                            }

                        case ConsoleKey.RightArrow:
                            { 
                                if (Console.CursorLeft > Console.WindowWidth)
                                    throw new Exception("going beyond");
                                RightHandler(this, EventArgs.Empty);
                                break;                             
                            }

                        case ConsoleKey.UpArrow:
                            {
                                if (Console.CursorTop - 1 < 0)
                                    throw new Exception("going beyond");
                                UpHandler(this, EventArgs.Empty);
                                break;                 
                            }

                        case ConsoleKey.DownArrow:
                            {                         
                                if (Console.CursorTop > Console.WindowWidth)
                                    throw new Exception("going beyond");
                                DownHandler(this, EventArgs.Empty);
                                break; 
                            }
                        default:
                            {
                                Console.WriteLine("Incorrect input\n");
                                return;
                            }
                    }
                }
            }

            catch (Exception newExc)
            {
                Console.WriteLine(newExc.Message);
            }
        }
    }
}  