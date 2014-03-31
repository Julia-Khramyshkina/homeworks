using System;

namespace Homework5_task1
{
    public class ClassForFunction 
    {
        /// <summary>
        /// Conversion list.
        /// </summary>
        /// <param name="list">Necessary list.</param>
        /// <param name="somethingFunction">"Sly" function.</param>
        public void Map(List list, Func<int, int> somethingFunction)
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
        public List Filter(List list, Func<int, bool> check)
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
        public int Fold(List list, int value, Func<int, int, int> function)
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
    }
}
