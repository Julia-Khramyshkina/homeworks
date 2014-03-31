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
            while (true)
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            try
                            {                             
                                if (Console.CursorLeft - 1 < 0)
                                    throw new Exception("going beyond");
                                LeftHandler(this, EventArgs.Empty);
                                break;
                             }
                             catch (Exception e)
                             {
                                 Console.WriteLine(e.Message);
                                 break;
                             }
                             
                        }

                    case ConsoleKey.RightArrow:
                        {
                            try
                            {
                                if (Console.CursorLeft > Console.WindowWidth)
                                    throw new Exception("going beyond");
                                RightHandler(this, EventArgs.Empty);
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                return;
                            }
                             
                        }

                    case ConsoleKey.UpArrow:
                        {
                            try
                            {
                                if (Console.CursorTop - 1 < 0)
                                    throw new Exception("going beyond");
                                UpHandler(this, EventArgs.Empty);
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                break;
                            }
                        }

                    case ConsoleKey.DownArrow:
                        {
                            try
                            {
                                if (Console.CursorTop > Console.WindowWidth)
                                    throw new Exception("going beyond");
                                DownHandler(this, EventArgs.Empty);
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                break;
                            }
                        }

                }
            }
        }
    }
}  