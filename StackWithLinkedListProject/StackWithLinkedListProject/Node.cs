using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithLinkedListProject
{
    public class Node
    {
        public int DataOfNote { get; set; }
        public Node? Next { get; set; }

        public Node(int value) => DataOfNote = value;
    }
}
