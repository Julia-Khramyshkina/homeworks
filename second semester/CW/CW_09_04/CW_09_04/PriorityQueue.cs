using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_09_04
{
    public class PriorityQueue
    {
        private int Size = 500;
        private List[] ourListForQueue = new List[500];

        public PriorityQueue()
        {
            for (int i = Size; i > 0; --i)
            {
                ourListForQueue[i] = new List(-1);
            }
        }

        public void Enqueue(int value, int priority)
        {
            for (int i = Size; i > 0; --i)
            {
                if (ourListForQueue[i].Priority() <= priority)
                {
                    if (priority == -1)
                    {
                        ourListForQueue[i].ChangePriority(priority);
                        ourListForQueue[i].InsertToEnd(value);
                        return;
                    }
                    ourListForQueue[i].InsertToEnd(value);
                    return;
                }
            }
        }

        public int Dequeue()
        {
            int value = -33333;
            for (int i = Size; i > 0; --i)
            {
                if (ourListForQueue[i].Priority() == -1)
                    throw new Exception("Oueue is empty");
                value = ourListForQueue[i].ValueFromHead();
                ourListForQueue[i].RemoveFromHead();
            
                break;
            }
            return value;

        }

        public bool IsEmpty()
        {
            for (int i = Size; i > 0; --i)
            {
                if (ourListForQueue[i].Priority() == -1)
                    return true;
            }
            return false;
        }

    }
}
