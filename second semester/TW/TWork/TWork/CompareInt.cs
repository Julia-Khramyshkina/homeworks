using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWork
{
    /// <summary>
    /// Comparator for int.
    /// </summary>
    public class CompareInt : CompareInterface<int>
    {
        /// <summary>
        /// Method for compare integer number's.
        /// </summary>
        /// <param name="value1">Value for compare.</param>
        /// <param name="value2">Value for compare.</param>
        /// <returns></returns>
        public int Compare(int value1, int value2)
        {
            if (value1 > value2)
                return 1;
            if (value1 < value2)
                return -1;
            return 0;
        }
    }
}
