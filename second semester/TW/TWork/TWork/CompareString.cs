using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWork
{
    /// <summary>
    /// Comparator for string
    /// </summary>
    public class CompareString : CompareInterface<string>
    {
        /// <summary>
        /// Method for compare string's.
        /// </summary>
        /// <param name="value1">Value for compare.</param>
        /// <param name="value2">Value for compare.</param>
        /// <returns></returns>
        public int Compare(string value1, string value2)
        {
            int i = 0;
            while (i != value1.Length && i != value2.Length)
            {
                if (value1[i] > value2[i])
                    return 1;
                if (value1[i] < value2[i])
                    return -1;
                if (value1[i] == value2[i])
                    ++i;
            }
            if (i == value1.Length && i == value2.Length)
                return 0;
            if (i == value1.Length)
                return -1;
            return 1;
        }
    }
}
