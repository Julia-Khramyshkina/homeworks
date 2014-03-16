using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework2_task4.Tests
{
    using GeneralStack;
    using NameSpaceCalculator;
    [TestClass]
    public class CalculatorTest
    {
        private Calculator calculator;
        private Calculator calculatorWithStackOnArray;
       
        [TestInitialize]
        public void Initialize()
        {
            GenStack stack = new Stack();
            calculator = new Calculator(stack);

            GenStack stackArray = new StackArray();
            calculatorWithStackOnArray = new Calculator(stackArray);
        }

        [TestMethod]
        public void PopValueTest()
        {
            calculator.PushResult(1);
            var result = calculator.PopValue();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void PopValueTestEqual()
        {
            calculatorWithStackOnArray.PushResult(1);
            calculator.PushResult(1);
            Assert.AreEqual(calculator.PopValue(), calculatorWithStackOnArray.PopValue());
        }

        [TestMethod]
        public void AdditionTest()
        {
            calculator.PushResult(1);
            calculator.PushResult(2);
            calculator.Addition();
            var result = calculator.PopValue();
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void AdditionTestEqual()
        {
            calculator.PushResult(1);
            calculator.PushResult(2);
            calculator.Addition();

            calculatorWithStackOnArray.PushResult(1);
            calculatorWithStackOnArray.PushResult(2);
            calculatorWithStackOnArray.Addition();

            Assert.AreEqual(calculator.PopValue(), calculatorWithStackOnArray.PopValue());
        }

        [TestMethod]
        public void SubtractionTest()
        {
            calculator.PushResult(1);
            calculator.PushResult(2);
            calculator.Subtraction();
            var result = calculator.PopValue();
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void SubtractionTestEqual()
        {
            calculator.PushResult(1);
            calculator.PushResult(2);
            calculator.Subtraction();

            calculatorWithStackOnArray.PushResult(1);
            calculatorWithStackOnArray.PushResult(2);
            calculatorWithStackOnArray.Subtraction();

            Assert.AreEqual(calculator.PopValue(), calculatorWithStackOnArray.PopValue());
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            calculator.PushResult(3);
            calculator.PushResult(2);
            calculator.Multiplication();
            var result = calculator.PopValue();
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void MultiplicationTestEqual()
        {
            calculator.PushResult(3);
            calculator.PushResult(2);
            calculator.Multiplication();

            calculatorWithStackOnArray.PushResult(3);
            calculatorWithStackOnArray.PushResult(2);
            calculatorWithStackOnArray.Multiplication();

            Assert.AreEqual(calculator.PopValue(), calculatorWithStackOnArray.PopValue());
        }

        [TestMethod]
        public void DivisionTest()
        {          
            calculator.PushResult(2);
            calculator.PushResult(2);
            calculator.Division();
            var result = calculator.PopValue();
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void DivisionTestEqual()
        {
            calculator.PushResult(2);
            calculator.PushResult(2);
            calculator.Multiplication();

            calculatorWithStackOnArray.PushResult(2);
            calculatorWithStackOnArray.PushResult(2);
            calculatorWithStackOnArray.Multiplication();

            Assert.AreEqual(calculator.PopValue(), calculatorWithStackOnArray.PopValue());
        }
    }
}
