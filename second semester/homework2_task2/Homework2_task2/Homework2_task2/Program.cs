using System;


namespace Homework2_task2
{
    using NameSpaceForList;
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.InsertToHead(22);
            list.InsertToHead(21);
            list.InsertToHead(20);
            list.InsertToEnd(1);
            list.InsertToEnd(2);
            list.InsertToEnd(3) ;
            list.RemoveElement(1);
        }
    }
}
