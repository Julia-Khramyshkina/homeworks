namespace Homework4_task1
{
    public class Operand : Node
    {
        private ElementOfTree position;
        public Operand(ElementOfTree position)
        {
            this.position = position;
        }
        public Operand()
            : base()
        {
        }


        public int ValueOfOperand()
        {
            return this.first().ValueOfInt;
        }
    }
}
