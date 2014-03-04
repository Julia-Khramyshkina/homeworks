using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceForStackWithArray
{
    /// <summary>
    /// Stack.
    /// </summary>
    public class Stack
    {
        private class StackElement
        {
            private int [] aValue = new int [100];
            private int i = 0;

            public int Value
            {
                get
                {
                    ++i;
                    return aValue[i];
                }

                set
                {
                    this.aValue[i] = value;
                    ++i;
                }
            }

            public StackElement [] Next { get; set; }
            //public int ValueOfIndex
            //{
            //    get
            //    {
            //        return i;
            //    }
            //    set
            //    {
            //        this.i = value;
            //    }
            //}
     
        
        
        
        
        
        
        













        }

        private StackElement [] head = new StackElement[0];

        /// <summary>
        /// Push value to a stack.
        /// </summary>
        /// <param name="Value to be pushed."></param>
        //public void Push(int value)
        //{
        //    var  newElement = new StackElement[]
        //    {
        //        Next = head,
        //        Value = value,
        //    };

        //    head = newElement;
        //}

        /// <summary>
        /// Get value from stack.
        /// </summary>
        //public int Pop()
        //{
        //    //if (head == 0)
        //    //{
        //    //    return -1;
        //    //}

        //    //var temp = head.Value;
        //    //head = head.Next;
        //    //return temp;
        //}

        /// <summary>
        /// Checking stack. Empty?
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return head == null;
        }
    }
}