using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_task4
{
    /// <summary>
    /// class -- The EvenLoop 
    /// </summary>
    public class EventLoop
    {
        public event EventHandler<EventArgs> LeftHandler = (sender, args) => { };
        public event EventHandler<EventArgs> RightHandler = (sender, args) => { };
        public event EventHandler<EventArgs> UpHandler = (sender, args) => { };
        public event EventHandler<EventArgs> DownHandler = (sender, args) => { };

        /// <summary>
        /// Launch of an infinite event loop.
        /// </summary>
        public void Run()
        {
            while (true)
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            LeftHandler(this, EventArgs.Empty);
                            break;
                        }

                    case ConsoleKey.RightArrow:
                        { 
                            RightHandler(this, EventArgs.Empty);
                            break;                             
                        }

                    case ConsoleKey.UpArrow:
                        {
                            UpHandler(this, EventArgs.Empty);
                            break;                 
                        }

                    case ConsoleKey.DownArrow:
                        {                         
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
    }
}  