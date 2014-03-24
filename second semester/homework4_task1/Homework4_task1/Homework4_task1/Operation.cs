namespace Homework4_task1
{
    public class Operation : Node
    {
        public Operation(ElementOfTree position): base()
        {
        }
        public char ValueOfOperation()
        {
            return this.first().ValueOfChar;
        }
    }
}
