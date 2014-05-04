using System;

namespace Homework4_task1
{
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public String Value { get; set; }

        public Node(String value, int temp)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }

        public Node First()
        {
            return this.head;
        }
        public Node()
        {
        }
        public Node(String value)
        {
            this.Value = value;
        }

        public virtual void Calculate()
        {
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
                if (true)
                {
                    switch (input[i])
                    {
                        case '+':
                            {
                              //  this.head = new Addition(input[i].ToString(), 0);
                                break;
                            }
                        case '-':
                            {
                                current = new Subtraction(input[i].ToString(), 0);
                              //  this.head = current;
                                break;
                            }
                        case '*':
                            {
                                current = new Multiplication(input[i].ToString(), 0);
                              //  this.head = current;
                                break;
                            }
                        case '/':
                            {
                                current = new Division(input[i].ToString(), 0);
                               // this.head = current;
                                break;
                            }
                    }


                    //  InsertMini(input, i, this.head);
                    //  current = this.head;
                    ++i;
                }
                else
                {
                    //if (position == null)
                    //    return;
                    if (current.Left == null)
                    {
                      //  InsertMini(input, i, current.Left);

                        current = current.Left;
                        ++i;
                    }
                    else
                    {
                        if (current.Right == null)
                        {
                            //InsertMini(input, i, current.Right);

                            current = current.Right;
                            ++i;
                        }
                        else
                        {
                            while (current.Left != null)
                            {
                                current = current.Left;
                            }
                            InsertMini(input, i, current.Left);
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
                    current.Left = new Operand(input[i].ToString());
                    ++i;
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = new Operand(input[i].ToString());
                        ++i;
                    }
                }
            }
            InsertElement(input, ref i, current);
        }

    }






















    //public class Node : Tree
    //{
        

    //    public override void Calculate()
    //    {

    //        if (this.ValueOfChar == '+')
    //        {
    //            this.ValueOfInt = (this.Left.ValueOfInt) + (this.Right.ValueOfInt);
    //        }

    //        if (this.ValueOfChar == '-')
    //        {
    //            this.ValueOfInt = this.Left.ValueOfInt - this.Right.ValueOfInt;
    //        }

    //        if (this.ValueOfChar == '*')
    //        {
    //            this.ValueOfInt = this.Left.ValueOfInt * this.Right.ValueOfInt;
    //        }
    //        if (this.ValueOfChar == '/')
    //        {
    //            this.ValueOfInt = this.Left.ValueOfInt / this.Right.ValueOfInt;
    //        }
    //    }
    //}

}
