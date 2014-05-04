namespace Homework4_task1
{
    public class Tree
    {
        protected Node head = null;

        public virtual void Calculate()
        {
            Node newNode = this.head;
            newNode.Calculate();
        }

        public Node First()
        {
            return this.head;
        }

        public void InsertElement(string input, ref int i, Node current)
        {

            if (input[i] == '(')
            {
                ++i;
                InsertElement(input, ref i, current);
            }

            if (i == input.Length)
            {
                return;
            }

            if (input[i] == ')')
            {
                ++i;
                return;
            }


            if (input[i - 1] == ')' && (input[i] >= '9' || input[i] <= '0') && input[i] != '(')
            {
                return;
            }


            if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
            {
                if (this.head == null)
                {
                    this.head = new Node(input[i], 0);
                    current = this.head;
                    ++i;
                }
                else
                {
                    //if (position == null)
                    //    return;
                    if (current.Left == null)
                    {
                        current.Left = new Node(input[i], 0);
                        current = current.Left;
                        ++i;
                    }
                    else
                    {
                        if (current.Right == null)
                        {
                            current.Right = new Node(input[i], 0);
                            current = current.Right;
                            ++i;
                        }
                        else
                        {
                            while (current.Left != null)
                            {
                                current = current.Left;
                            }
                            current.Left = new Node(input[i], 0);
                            current = current.Left;
                            ++i;
                        }
                    }
                }
            }
            if (input[i] >= '0' && input[i] <= '9')
            {
                int value = input[i] - 48;
                if (current.Left == null)
                {
                    current.Left = new Node('!', value);
                    ++i;
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = new Node('!', value);
                        ++i;
                    }
                }
            }
            InsertElement(input, ref i, current);
        }

        public void CalculateTree(Node current)
        {
            if (current.Left != null)
            {
                CalculateTree(current.Left);          
                current.Calculate();

            }

            if (current.Right != null)
            {
                CalculateTree(current.Right);
                current.Calculate();
            }
        }

    }

}