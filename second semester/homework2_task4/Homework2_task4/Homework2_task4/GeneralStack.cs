using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralStack
{
    abstract public class GeneralStack
    {
        public abstract class StackElement
        {
        }
        
        public abstract int Pop();

        public abstract void Push(int value);
    }
}
