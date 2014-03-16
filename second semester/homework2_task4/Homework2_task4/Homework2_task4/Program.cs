namespace Homework2_task4
{
    using GeneralStack;
    using NameSpaceCalculator;
    class Program
    {
        static void Main(string[] args)
        {
            GenStack stack = new Stack();
            Calculator qwety = new Calculator(stack);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            qwety.Addition();
            int x = qwety.PopValue();

            GenStack stackOfArray = new StackArray();
            Calculator qwerty = new Calculator(stackOfArray);
            stackOfArray.Push(23);
            stackOfArray.Push(11);
            qwerty.Subtraction();
            int y = qwerty.PopValue();
        }
    }
}
