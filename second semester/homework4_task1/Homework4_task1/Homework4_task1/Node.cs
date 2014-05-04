namespace Homework4_task1
{
    public class Node : Tree
    {
        public char ValueOfChar { get; set; }
        public int ValueOfInt { get; set; }

        public Node(char valueOfChar, int valueOfInt)
        {
            ValueOfChar = valueOfChar;
            ValueOfInt = valueOfInt;
            Left = null;
            Right = null;
        }

        public Node()
        {
        }

        public Node Left { get; set; }
        public Node Right { get; set; }

        public override void Calculate()
        {

            if (this.ValueOfChar == '+')
            {
                this.ValueOfInt = (this.Left.ValueOfInt) + (this.Right.ValueOfInt);
            }

            if (this.ValueOfChar == '-')
            {
                this.ValueOfInt = this.Left.ValueOfInt - this.Right.ValueOfInt;
            }

            if (this.ValueOfChar == '*')
            {
                this.ValueOfInt = this.Left.ValueOfInt * this.Right.ValueOfInt;
            }
            if (this.ValueOfChar == '/')
            {
                this.ValueOfInt = this.Left.ValueOfInt / this.Right.ValueOfInt;
            }
        }
    }

}
