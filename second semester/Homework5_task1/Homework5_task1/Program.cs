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
        Func<int, int> x2 = x => x * 2;

        public static void Map(List list, Func<int,int> x2)
        {
            int end = list.SizeOfList();   
            var temp = list.First();
            for (int i = 0; i < end; ++i)
            {
                temp.Value = x2(temp.Value);
                temp = temp.Next;
            }
        }



        static void Main(string[] args)
        {
            List list = new List();

            for (int i = 0; i < 4; ++i)
            {
                list.InsertToEnd(i);
            }

            list.PrintList();

          //  Map(list, Func<int,int> x2);
            list.PrintList();
        }
    }
}

