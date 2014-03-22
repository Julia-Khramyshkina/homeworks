namespace Homework4_task1
{
    public class Tree
    {
       
        private class ElementOfTree
        {
            public int ValueOfChar { get; set; }
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

        public void InsertElementOfInt(int newElement)
        {
            var newElementOfTree = new ElementOfTree('0', newElement);
            if (IsEmpty())
            {
                head = newElementOfTree;
                return;
            }
            var tempElement = this.head;
            bool less = true;
            while (true)
            {
                if (newElement < tempElement.ValueOfInt)
                {
                    less = true;
                    if (tempElement.Left != null)
                    {
                        tempElement = tempElement.Left;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    less = false;
                    if (tempElement.Right != null)
                    {
                        tempElement = tempElement.Right;
                    }
                    else
                    {
                        break;
                    }
                    tempElement = tempElement.Right;
                }
            }

            if (less)
            {
                tempElement.Left = new ElementOfTree('0', newElement);
            }
            else
            {
                tempElement.Right = new ElementOfTree('0', newElement);

            }
   
           
        }






    }
}
