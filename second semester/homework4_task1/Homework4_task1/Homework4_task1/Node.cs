namespace Homework4_task1
{
    public class Node : Tree
    {
        private ElementOfTree position;

        public Node() :base()       
        { 
        }

     
        public Node(ElementOfTree position)
        {
            this.position = position;
        }

        public int Consider()
        {
            Operation operation = new Operation(position);
           // Operand operandLeft = new Operand(position);
            //Operand operandRight = new Operand();
            return 0;

        }
    }
}
