//using System.MulticastDelegate;
//using System.Delegate;
//using System.Linq.Expressions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework5_task1
{
    class Program
    {
        /// <summary>
        /// Conversion list.
        /// </summary>
        /// <param name="list">Necessary list.</param>
        /// <param name="somethingFunction">"Sly" function.</param>
        public static void Map(List list, Func<int,int> somethingFunction)
        {
            int end = list.SizeOfList();   
            var temp = list.First();
            for (int i = 0; i < end; ++i)
            {
                temp.Value = somethingFunction(temp.Value);
                temp = temp.Next;
            }
        }

        /// <summary>
        /// Filter function.
        /// </summary>
        /// <param name="list">Necessary list.</param>
        /// <param name="check">"Sly" function.</param>
        /// <returns></returns>
        public static List Filter(List list, Func<int, bool> check)
        {
            List newList = new List();
            int end = list.SizeOfList();
            var temp = list.First();
            var temNewList = newList.First();

            for (int i = 0; i < end; ++i)
            {
                if (check(temp.Value))
                {
                    newList.InsertToEnd(temp.Value);
                }
                temp = temp.Next;
            }
            return newList;
        }

        /// <summary>
        /// Storage function.
        /// </summary>
        /// <param name="list">Necessary list.</param>
        /// <param name="value">Started value.S</param>
        /// <param name="function">"Sly" function.</param>
        /// <returns></returns>
        public static int Fold(List list, int value, Func<int, int, int> function)
        {

            int end = list.SizeOfList();
            var temp = list.First();
            for (int i = 0; i < end; ++i)
            {
                value = function(value, temp.Value);
                temp = temp.Next;
            }
            return value;
        }

        static void Main(string[] args)
        {
            List list = new List();
            Func<int, int> somethingG = x => x * 2;
            Func<int, bool> somethingCheck = x => (x % 3) == 0;
            Func<int, int, int> thisFunction = (x, y) => x * y;
            for (int i = 1; i < 4; ++i)
            {
                list.InsertToEnd(i);
            }

            list.PrintList();

            Map(list, somethingG);
            list.PrintList();
            List newList = new List();
            newList = Filter(list, somethingCheck);
            newList.PrintList();

            int value = Fold(list, 1, thisFunction);
            System.Console.WriteLine("{0}", value);

        }
    }
}

