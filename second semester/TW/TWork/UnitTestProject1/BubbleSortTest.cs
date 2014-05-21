using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    using TWork;
    [TestClass]
    public class BubbleSortTest
    {
        [TestMethod]
        public void TestInt()
        {
            BubbleSort<int> sortClass = new BubbleSort<int>();
            CompareInterface<int> comparator = new CompareInt();
            int[] array = new int[3];
            for (int i = 0; i < 3; ++i)
            {
                array[i] = i;
            }
            sortClass.BubbleSortFunction(comparator, ref array, 3);
            Assert.AreEqual(array[0], 2);
            Assert.AreEqual(array[1], 1);
            Assert.AreEqual(array[2], 0);
        }

        [TestMethod]
        public void TestString()
        {
            BubbleSort<string> sortClass = new BubbleSort<string>();
            CompareInterface<string> comparator = new CompareString();
            string[] array = new string[3];
            for (int i = 0; i < 3; ++i)
            {
                array[i] = i.ToString();
            }
            sortClass.BubbleSortFunction(comparator, ref array, 3);
            Assert.AreEqual(array[0], "2");
            Assert.AreEqual(array[1], "1");
            Assert.AreEqual(array[2], "0");
        }
    }
}