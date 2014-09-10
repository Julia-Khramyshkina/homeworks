using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace task1
{
    public class BinaryTreeSeach : IEnumerable<int>
    {
        private class ElementOfBinaryTreeSeach
        {
            public int Value { get; set; }
            public int Position { get; set; }
            public ElementOfBinaryTreeSeach(int value, int position)
            {
                Value = value;
                Position = position;
            }
            public ElementOfBinaryTreeSeach Left { get; set; }
            public ElementOfBinaryTreeSeach Right { get; set; }
        }
        private ElementOfBinaryTreeSeach head = null;
        private int size = 0;


        public IEnumerator<int> GetEnumerator()
        {
            return new MyEnumerator(this);
        }


        //private IEnumerator GetEnumerator1()
        //{
        //    return this.GetEnumerator();
        //}
        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator1();
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)(new MyEnumerator(this));
        }


     

    
        public class MyEnumerator : IEnumerator<int>
        {

        
            private int valueForNumerator = -1;
            private BinaryTreeSeach binaryTree;

            public MyEnumerator(BinaryTreeSeach binaryTree1)
            {
                this.binaryTree = binaryTree1;
            }


            public int Current
            {
                get
                {
                    return binaryTree.ValueOnPosition(valueForNumerator);
                }
            }


            private object Current1
            {

                get { return this.Current; }
            }

           
            object IEnumerator.Current
            {
                get { return Current1; }
            }


            /// <summary>
            /// Get value.
            /// </summary>
           


            /// <summary>
            /// Check possible moving.
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {

                if (binaryTree.head == null)
                    return false;
                if (binaryTree.head.Left == null && binaryTree.head.Right == null)
                {
                    Reset();
                    return false;
                }
                ++valueForNumerator;
                if (binaryTree.size == valueForNumerator)
                    return false;
               
                return true;
            }

            /// <summary>
            /// The transition to the pre-start position.
            /// </summary>
            public void Reset()
            {
                valueForNumerator = -1;
            }

   
            /// <summary>
            /// Releasing or resetting unmanaged resources.
            /// </summary>
            public void Dispose()
            {

            }
        }      

  
        public void InsertElement(int value)
        {
            if (ElementExist(value))
            {
                return;
            }

            if (this.head == null)
            {
                this.head = new ElementOfBinaryTreeSeach(value, size);
                return;
            }

            var counter = this.head;
            ++size;

            while (counter.Left != null || counter.Right != null)
            {
                if (value > counter.Value)
                {
                    if (counter.Right == null)
                    {
                        break;
                    }
                    counter = counter.Right;
                }
                else
                {
                    if (counter.Left == null)
                    {
                        break;
                    }
                    counter = counter.Left;
                }
            }
            if (counter.Value > value)
            {
                counter.Left = new ElementOfBinaryTreeSeach(value, size);
            }
            else
            {
                
                counter.Right = new ElementOfBinaryTreeSeach(value, size);
            }
        }


        private void AscendingDouble(ref ElementOfBinaryTreeSeach currentElement, int position, ref int resultPosition, ref ElementOfBinaryTreeSeach result)
        {
            ++resultPosition;
            if (currentElement != null)
            {
                
                if (resultPosition == position)
                    result = currentElement;

                currentElement = currentElement.Left;
                AscendingDouble(ref currentElement, position, ref resultPosition, ref result);
            }

           
            if (currentElement != null)
            {
                if (resultPosition == position)
                    result = currentElement;

                currentElement = currentElement.Right;
                AscendingDouble(ref currentElement, position, ref resultPosition, ref result);
            }
           
        }

        private int ValueOnPosition(int position)
        {
            ElementOfBinaryTreeSeach result = this.head;
            int resultPosition = 0;
            AscendingDouble(ref this.head, position, ref resultPosition, ref result);
            return result.Value;
        }


        public bool ElementExist(int value)
        {
            var counter = this.head;
            while (counter != null)
            {
                if (counter.Value < value)
                {
                    counter = counter.Right;
                }
                else if (counter.Value > value)
                {
                    counter = counter.Left;
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
            if (IsEmpty())
                return;

            if (!ElementExist(value))
                return;
            --size;
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
                        previousCounter = previousCounter.Right;
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
                if (previousCounter.Left == counter)
                    previousCounter.Left = null;
                else
                    previousCounter.Right = null;
                return;
            }

            if (counter.Left != null && counter.Right == null)
            {
                if (previousCounter.Left == counter)
                {
                    previousCounter.Left = counter.Left;
                    return;
                }
                else
                {
                    previousCounter.Right = counter.Left;
                    return;
                }
            }

            if (counter.Left == null && counter.Right != null)
            {
                if (previousCounter.Left == counter)
                {
                    previousCounter.Left = counter.Right;
                    return;
                }
                else
                {
                    previousCounter.Right = counter.Right;
                    return;
                }
            }

            if (counter.Left != null && counter.Right != null)
            {
                var searchCounter = counter.Right;
                
                while (searchCounter.Left != null)
                {
                    searchCounter = searchCounter.Left;
                }
                int saveValue = searchCounter.Value;
                RemoveElement(searchCounter.Value);
                counter.Value = saveValue;
            }
    }

        public bool IsEmpty()
        {
            return this.head == null;
        }





    }
}
