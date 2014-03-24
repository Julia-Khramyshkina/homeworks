namespace Homework4_task1
{
    public class Operation : Node
    {
        private ElementOfTree position;
        public Operation(ElementOfTree position)
        {
            this.position = position;
        }
        public Operation()
            : base()
        {
        }

        public char ValueOfOperation()
        {
            return this.first().ValueOfChar;
        }
    }
}
