﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceForStackWithArray
{
    using GeneralStack;
    /// <summary>
    /// Stack.
    /// </summary>
    public class StackArray : GeneralStack
    {

        public class StackElement
        {
            public int[] aValue { get; set; }
            public int aLast { get; set; }
            public StackElement(int value, int last)
            {
                aValue[aLast] = value;
                aLast = last;
            }
            public StackElement Next { get; set; }
        }
        //private StackElement head = aValue[0];


        /// <summary>
        /// Push value to a stack.
        /// </summary>
        /// <param name="Value to be pushed."></param>
        public override void Push(int value)
        {
            //var newElement = new StackElement(value)
            //{
            //    Next = aLast,
            //    aValue = value
            //};

            //head = newElement;
        }

        /// <summary>
        /// Get value from stack.
        /// </summary>
        public override int Pop()
        {
            return 0;
            //if (head == null)
            //{
            //    return -1;
            //}

            //var temp = head.aValue;
            //head = head.Next;
            //return temp;
        }





       // private StackElement head[0;] //= aValue[0];


        //public class StackElement
        //{
        //    public int aValue {get; set;}

        //    public StackElement(int value)
        //    {
        //        aValue = value;
        //    }

        //    public StackElement Next { get; set; }     
        //}

        //public StackArray()
        //{
            //for (int i = 0; i < 100; ++i)
            //{
            //   // stack[i] = value;
            //}
        //}

        //private StackElement[] head = new StackElement[0];

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
        //public bool IsEmpty()
        //{
        //    return head == null;
        //}
    }
}