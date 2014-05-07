using System;

namespace Homework4_task1
{
    /// <summary>
    /// Class for Tree.
    /// </summary>
    public class Tree
    {      
        private Node root = null;  

        /// <summary>
        /// Calculate tree.
        /// </summary>
        /// <returns></returns>
        public Double Calculate()
        {
            return this.root.Calculate();
        }

        /// <summary>
        /// Print tree.
        /// </summary>
        public void Print()
        {
            this.root.Print();
        }

        /// <summary>
        /// Parse tree.
        /// </summary>
        /// <param name="input">String that contains the tree.</param>
        public void Parse(string input)
        {
            int i = 0;
            this.root = TreeConstruction(input, ref i);
        }

        /// <summary>
        /// Tree construction and return new node.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public Node TreeConstruction(string input, ref int i)
        {
            if (input[i] == '(')
            {
                ++i;
                return TreeConstruction(input, ref i);
            }

            if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
            {
                switch (input[i])
                {
                    case '+':
                        {                         
                            ++i;
                            Node left = TreeConstruction(input, ref i);
                            ++i;
                            Node right = TreeConstruction(input, ref i);
                            ++i;
                            if (input[i] == ')')
                            {
                                return new Addition("+", left, right);
                            }
                            else
                                throw new Exception("Fail");                                
                        }
                    case '-':
                        {
                            ++i;
                            Node left = TreeConstruction(input, ref i);
                            ++i;
                            Node right = TreeConstruction(input, ref i);
                            ++i;
                            if (input[i] == ')')
                            {
                                return new Subtraction("-", left, right);
                            }
                            else
                                throw new Exception("Fail");
                        }
                    case '*':
                        {
                            ++i;
                            Node left = TreeConstruction(input, ref i);
                            ++i;
                            Node right = TreeConstruction(input, ref i);
                            ++i;
                            if (input[i] == ')')
                            {
                                return new Multiplication("+", left, right);
                            }
                            else
                                throw new Exception("Fail");
                        }
                    case '/':
                        {
                            ++i;
                            Node left = TreeConstruction(input, ref i);
                            ++i;
                            Node right = TreeConstruction(input, ref i);
                            ++i;
                            if (input[i] == ')')
                            {
                                return new Division("+", left, right);
                            }
                            else
                                throw new Exception("Fail");
                        }
                    }
                }

            if (input[i] >= '0' && input[i] <= '9')
            {
                return new Operand(Convert.ToDouble(input[i].ToString()));
            }
            throw new Exception("Fail!11");
        }  
    }
}