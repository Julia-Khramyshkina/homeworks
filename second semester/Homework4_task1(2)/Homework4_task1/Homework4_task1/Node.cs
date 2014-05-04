using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_task1
{
    public class Node
    {
        public String Value { get; set; }

        public Node(String value)
        {
            Value = value;
        }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }

}
