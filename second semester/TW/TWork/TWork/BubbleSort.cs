using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWork
{
    /// <summary>
    /// Class for sorting with bubble.
    /// </summary>
    /// <typeparam name="ElementType">Type of elements, which we are sorting.</typeparam>
    public class BubbleSort<ElementType>
    {
        /// <summary>
        /// Method for bubble sort.
        /// </summary>
        /// <param name="comparator">Object for compare.</param>
        /// <param name="array">Our array.</param>
        /// <param name="size">Size of array.</param>
        public void BubbleSortFunction(CompareInterface<ElementType> comparator, ref ElementType[] array, int size)
        {
            for (int i = 0; i < (size - 1); ++i)
            {
                for (int j = 0; j < (size - 1); ++j)
                {
                    if (comparator.Compare(array[j + 1], array[j]) == 1)
                    {
                        ElementType temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
