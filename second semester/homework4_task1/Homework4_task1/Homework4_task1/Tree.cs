namespace Homework4_task1
{
    public class Tree
    {     
        public class ElementOfTree
        {
            public char ValueOfChar { get; set; }
            public int ValueOfInt { get; set; }
            public ElementOfTree(char valueOfChar, int valueOfInt)
            {
                ValueOfChar = valueOfChar;
                ValueOfInt = valueOfInt;
                Left = null;
                Right = null;
            }
        
            public ElementOfTree Left { get; set; }
            public ElementOfTree Right { get; set; }
        }
        private ElementOfTree head = null;

        public bool IsEmpty()
        {
            return head == null;
        }

        public ElementOfTree first()
        {
            return head;
        }

        public void InsertElement(string input, ref int i, ElementOfTree position)
        {

            if (input[i] == '(')
            {
                ++i;
                InsertElement(input, ref i, position);
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

            if (input[i - 1] == ')' && (input[i] >= '9' || input[i] <= '0') && input[i] != '(' )
            {
                return;
            }
            
            if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
            {
                if (this.head == null)
                {
                    this.head = new ElementOfTree(input[i], -1);
                    position = this.head;
                    ++i;
                }
                else
                {
                    //if (position == null)
                    //    return;
                    if (position.Left == null)
                    {
                        position.Left = new ElementOfTree(input[i], -1);
                        position = position.Left;
                        ++i;
                    }
                    else
                    {
                        if (position.Right == null)
                        {
                            position.Right = new ElementOfTree(input[i], -1);
                            position = position.Right;
                            ++i;
                        }
                        else
                        {
                            while (position.Left != null)
                            {
                                position = position.Left;
                            }
                            position.Left = new ElementOfTree(input[i], -1);
                            position = position.Left;
                            ++i;
                        }
                    }
                }
            }
            if (input[i] >= '0' && input[i] <= '9')
	        {
                int value = input[i] - 48;
		        if (position.Left == null)
		        {
			        position.Left = new ElementOfTree('0', value);
			        ++i;					
		        }
		        else
		        {
			        if (position.Right == null)
			        {
				        position.Right = new ElementOfTree('0', value);
				        ++i;
			        }			
		        }
	        }
	            InsertElement(input, ref i, position);
        }   
    }
    //public class Count : Tree
    //{


    //    public int Counter(ElementOfTree position, ElementOfTree preposition)
    //    {
    //        if (position.ValueOfInt != -1)
    //        {
    //            return position.ValueOfInt;
    //        }

    //        if (position.Left != null)
    //        {
    //            Counter(position.Left, position);
    //        }

    //        if (position.Right != null)
    //        {
    //            Counter(position.Right, position);
    //        }
    //        Operation ourOperation = new Operation(position);
    //        ourOperation.Choice();
    //        return position.ValueOfInt;
    //    }
    //}

   


 

}



