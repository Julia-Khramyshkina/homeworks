using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace task1
{
    /// <summary>
    /// Class for binary tree of seacrh.
    /// </summary>
    public class BinaryTreeSeach<ElementType> : IEnumerable<ElementType>
    {
        private class ElementOfBinaryTreeSeach
        {
            public ElementType Value { get; set; }
            public int Position { get; set; }
            public ElementOfBinaryTreeSeach(ElementType value)
            {
                Value = value;
            }
            public ElementOfBinaryTreeSeach Left { get; set; }
            public ElementOfBinaryTreeSeach Right { get; set; }
        }
        private ElementOfBinaryTreeSeach head = null;

        IEnumerator<ElementType> IEnumerable<ElementType>.GetEnumerator()
        {
            return new TreeEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)(new TreeEnumerator(this));
        }

        /// <summary
        /// Class for travel in our tree.
        /// </summary>
        public class TreeEnumerator : IEnumerator<ElementType>
        {
            private int valueForNumerator = -1;
            private BinaryTreeSeach<ElementType> binaryTree;
            private List<ElementType> listForBinaryTree = new List<ElementType>();

            public TreeEnumerator(BinaryTreeSeach<ElementType> binaryTree1)
            {
                this.binaryTree = binaryTree1;
                Ascending(binaryTree.head);
            }

            /// <summary>
            /// Bypass for move.
            /// </summary>
            /// <param name="currentElement">Start position of bypass.</param>
            private void Ascending(ElementOfBinaryTreeSeach currentElement)
            {
                if (binaryTree.head == null)
                    return;

                if (currentElement != null)
                {
                    listForBinaryTree.Add(currentElement.Value);
                }
             
                if (currentElement.Left != null)
                {             
                    Ascending(currentElement.Left);
                }
           
                if (currentElement.Right != null)
                {
                    Ascending(currentElement.Right);
                }
            }

            /// <summary>
            /// Get value.
            /// </summary>
            public ElementType Current
            {
                get
                {
                   return listForBinaryTree.ElementAt(valueForNumerator);
                }
            }

            /// <summary>
            /// Get object.
            /// </summary>
            private object Current1
            {
                get
                {
                    return this.Current;
                }
            }

            /// <summary>
            /// Get object.
            /// </summary>
            object IEnumerator.Current
            {
                get
                { 
                    return Current1;
                }
            }

            /// <summary>
            /// Check possible moving.
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {
                if (listForBinaryTree.Count == 0)
                    return false;

                if (listForBinaryTree.First() == null)
                    return false;

                if (listForBinaryTree.ElementAt(1) == null)
                {
                    Reset();
                    return false;
                }
                ++valueForNumerator;

                return !(listForBinaryTree.Count == valueForNumerator);
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
 
        /// <summary>
        /// Insert element to tree.
        /// </summary>
        /// <param name="value"></param>
        public void InsertElement(ElementType value, CompareInterface<ElementType> comparator)
        {
            if (ElementExist(value, comparator))
            {
                return;
            }

            if (this.head == null)
            {
                this.head = new ElementOfBinaryTreeSeach(value);
                return;
            }

            var counter = this.head;

            while (counter.Left != null || counter.Right != null)
            {
                if (comparator.Compare(value, counter.Value) == 1)
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
            if (comparator.Compare(value, counter.Value) == -1)
            {
                counter.Left = new ElementOfBinaryTreeSeach(value);
            }
            else
            {       
                counter.Right = new ElementOfBinaryTreeSeach(value);
            }
        }

        /// <summary>
        /// Checking exist.
        /// </summary>
        /// <param name="value">Value of this element.</param>
        /// <returns></returns>
        public bool ElementExist(ElementType value, CompareInterface<ElementType> comparator)
        {
            var counter = this.head;
            while (counter != null)
            {
                if (comparator.Compare(value, counter.Value) == 1)
                {
                    counter = counter.Right;
                }
                else if (comparator.Compare(value, counter.Value) == -1)
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

        /// <summary>
        /// Get position of need element.
        /// </summary>
        /// <param name="value">Value of element.</param>
        /// <param name="comparator">Comparator for this type of elements.</param>
        /// <returns>Element, which we are searching.</returns>
        private ElementOfBinaryTreeSeach SearchElement(ElementType value, CompareInterface<ElementType> comparator)
        {
            var counter = this.head;
            var previousCounter = this.head;           
            while (comparator.Compare(counter.Value, value) != 0)
            {
                if (comparator.Compare(counter.Value, value) == 0)
                {
                    break;
                }

                if (comparator.Compare(counter.Value, value) == -1)
                {
                    counter = counter.Right;
                    if (comparator.Compare(previousCounter.Right.Value, value) != 0)
                    {
                        previousCounter = previousCounter.Right;
                    }
                }
                else
                {
                    counter = counter.Left;
                    if (comparator.Compare(previousCounter.Left.Value, value) != 0)
                    {
                        previousCounter = previousCounter.Left;
                    }
                }
            }
            return previousCounter;
        }

        /// <summary>
        /// Removing element.
        /// </summary>
        /// <param name="value">Value of this element.</param>
        public void RemoveElement(ElementType value, CompareInterface<ElementType> comparator)
        {
            if (IsEmpty())
                return;

            if (!ElementExist(value, comparator))
                return;

            var counter = this.head;
            var previousCounter = SearchElement(value, comparator);
           
            if (counter == previousCounter)
            {
                this.head = null;
                return;
            }

            if (comparator.Compare(previousCounter.Left.Value, value) == 0)
            {
                counter = previousCounter.Left;
            }
            else
            {
                counter = previousCounter.Right;
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
                ElementType saveValue = searchCounter.Value;
                RemoveElement(searchCounter.Value, comparator);
                counter.Value = saveValue;
            }
        }

        /// <summary>
        /// Check tree. Empty?
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return this.head == null;
        }
    }
}
