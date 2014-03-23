using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new UniqueList();
            try
            {
                list.InsertToEnd(1);
                list.InsertToHead(2);
                list.InsertToThisPosition(1, 1);
            }
          


            catch (Exception e) 
            {
                System.Console.WriteLine(e.Message);
            }

        }
    }
}
