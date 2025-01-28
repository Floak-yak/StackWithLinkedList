namespace StackWithLinkedListProject
{
    public class StackWithLinkedList
    {
        private LinkedList linkedList { get; set; }
        private int Top { get; set; }
        public StackWithLinkedList()
        {
            linkedList = new LinkedList();
            Top = -1;
        }


        //O(1)
        public void Push(int item)
        {
            linkedList.AddNode(item);
            Top += 1;
        }

        //O(1)
        public Node Pop()
        {
            if (Top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            Node result = linkedList.GetTail();
            --Top;
            linkedList.RemoveTail();
            return result;
        }

        //O(1)
        public Node Peek()
        {
            if (Top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return linkedList.GetTail();
        }

        //O(1)
        public bool IsEmpty()
        {
            if (Top == -1)
                return false;
            else
                return true;
        }

        //O(1)
        public int Count()
        {
            return Top + 1;
        }
    }
}