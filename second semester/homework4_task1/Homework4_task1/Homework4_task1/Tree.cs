using System;
namespace Homework4_task1
{
    public class Tree
    {
       
        private Node head = null;  

        public Node First()
        {
            return this.head;
        }


        public void InsertMini(String input, int i, Node current)
        {
            //switch (input[i])
            //{
            //    case '+':
            //        {
            //            current = new Addition(input[i].ToString(), 0);
            //            break;
            //        }
            //    case '-':
            //        {
            //            current = new Subtraction(input[i].ToString(), 0);
            //            break;
            //        }
            //    case '*':
            //        {
            //            current = new Multiplication(input[i].ToString(), 0);
            //            break;
            //        }
            //    case '/':
            //        {
            //            current = new Division(input[i].ToString(), 0);
            //            break;
            //        }
            //}
        }

        //public void InsertElement(string input, ref int i, Node current)
        //{

        //    if (input[i] == '(')
        //    {
        //        ++i;
        //        InsertElement(input, ref i, current);
        //    }

        //    if (i == input.Length)
        //    {
        //        return;
        //    }

        //    if (input[i] == ')')
        //    {
        //        ++i;
        //        return;
        //    }


        //    if (input[i - 1] == ')' && (input[i] >= '9' || input[i] <= '0') && input[i] != '(')
        //    {
        //        return;
        //    }


        //    if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
        //    {
        //        if (this.head == null)
        //        {
        //            switch (input[i])
        //            {
        //                case '+':
        //                    {
        //                        this.head = new Addition(input[i].ToString(), 0);
        //                        break;
        //                    }
        //                case '-':
        //                    {
        //                        current = new Subtraction(input[i].ToString(), 0);
        //                        this.head = current;
        //                        break;
        //                    }
        //                case '*':
        //                    {
        //                        current = new Multiplication(input[i].ToString(), 0);
        //                        this.head = current;
        //                        break;
        //                    }
        //                case '/':
        //                    {
        //                        current = new Division(input[i].ToString(), 0);
        //                        this.head = current;
        //                        break;
        //                    }
        //            }


        //          //  InsertMini(input, i, this.head);
        //          //  current = this.head;
        //            ++i;
        //        }
        //        else
        //        {
        //            //if (position == null)
        //            //    return;
        //            if (current.Left == null)
        //            {
        //                InsertMini(input, i, current.Left);
                       
        //                current = current.Left;
        //                ++i;
        //            }
        //            else
        //            {
        //                if (current.Right == null)
        //                {
        //                    InsertMini(input, i, current.Right);
                          
        //                    current = current.Right;
        //                    ++i;
        //                }
        //                else
        //                {
        //                    while (current.Left != null)
        //                    {
        //                        current = current.Left;
        //                    }
        //                    InsertMini(input, i, current.Left);
        //                    current = current.Left;
        //                    ++i;
        //                }
        //            }
        //        }
        //    }
        //    if (input[i] >= '0' && input[i] <= '9')
        //    {
        //        int value = input[i] - 48;
        //        if (current.Left == null)
        //        {
        //            current.Left = new Operand(input[i].ToString());
        //            ++i;
        //        }
        //        else
        //        {
        //            if (current.Right == null)
        //            {
        //                current.Right = new Operand(input[i].ToString());
        //                ++i;
        //            }
        //        }
        //    }
        //    InsertElement(input, ref i, current);
        //}


        //public void CalculateTree(Node current)
        //{
        //    if (current.Left != null)
        //    {
        //        CalculateTree(current.Left);          
        //        current.Calculate();
        //    }

        //    if (current.Right != null)
        //    {
        //        CalculateTree(current.Right);
        //        current.Calculate();
        //    }
        //}

    }

}