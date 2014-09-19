using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    /// <summary>
    /// Interface for compare.
    /// </summary>
    /// <typeparam name="ElementType">Type of elements, which we will compare.</typeparam>
    public interface CompareInterface<ElementType>
    {
        /// <summary>
        /// Function for compare.
        /// </summary>
        /// <param name="value1">Value for compare.</param>
        /// <param name="value2">Value for compare.</param>
        /// <returns></returns>
        int Compare(ElementType value1, ElementType value2);
    }

}
