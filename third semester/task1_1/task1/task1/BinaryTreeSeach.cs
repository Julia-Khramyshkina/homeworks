using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class BinaryTreeSeach
    {
        private class ElementOfBinaryTreeSeach
        {
            public int Value { get; set; }
            public ElementOfBinaryTreeSeach(int value)
            {
                Value = value;
            }
            public ElementOfBinaryTreeSeach Left { get; set; }
            public ElementOfBinaryTreeSeach Right { get; set; }
        }
        private ElementOfBinaryTreeSeach head = null;

        public void InsertElement(int value)
        {
            if (ElementExist(value))
            {
                return;
            }

            var counter = this.head;
            while (counter != null)
            {
                if (counter.Value < value)
                {
                    counter = counter.Left;
                }
                else
                {
                    counter = counter.Right;
                }
            }
            counter = new ElementOfBinaryTreeSeach(value);
        }

        public bool ElementExist(int value)
        {
            var counter = this.head;
            while (counter != null)
            {
                if (counter.Value < value)
                {
                    counter = counter.Left;
                }
                else if (counter.Value > value)
                {
                    counter = counter.Right;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public void RemoveElement(int value)
        {
            var counter = this.head;
            var previousCounter = this.head;
            while (counter.Value != value)
            {
                if (counter.Value == value)
                {
                    break;
                }
                if (counter.Value < value)
                {
                    counter = counter.Right;
                    if (previousCounter.Right.Value != value)
                    {
                        previousCounter = previousCounter.Right.;
                    }
                }
                else
                {
                    counter = counter.Left;
                    if (previousCounter.Left.Value != value)
                    {
                        previousCounter = previousCounter.Left;
                    }
                }
            }

            if (counter.Left == null && counter.Right == null)
            {
                counter = null;
            }

            if (counter.Left != null && counter.Right == null)
            {
                if (previousCounter.Left == counter)
                {
                    previousCounter.Left = counter.Left;
                }
                else
                {
                    previousCounter.Right = counter.Left;;
                }
            }

            if (counter.Left == null && counter.Right != null)
            {
                if (previousCounter.Left == counter)
                {
                    previousCounter.Left = counter.Right;
                }
                else
                {
                    previousCounter.Right = counter.Right;
                }
            }


            if (counter.Left != null && counter.Right != null)
            {
                var searchCounter = counter.Right;
                
                while (searchCounter.Left != null)
                {
                    searchCounter = searchCounter.Left;
                }
                RemoveElement(searchCounter.Value);
            }

    }
}
