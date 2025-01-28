using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithLinkedListProject
{
    public class LinkedList
    {
        private Node? Head { get; set; }
        public Node? Tail { get; set; }

        public void AddNode(int value)
        {
            if (Head == null)
            {
                Head = new Node(value);
                Tail = Head;
                return;
            }

            Node tempNode = Tail;
            Tail = new Node(value);
            tempNode.Next = Tail;
        }

        public void InserHead(int value)
        {
            if (Head is null)
            {
                Head = Tail = new Node(value);
                return;
            }

            Node newNode = Head;
            Head = new(value)
            {
                Next = newNode
            };
        }

        public void InserTail(int value)
        {
            if (Tail is null)
            {
                Head = Tail = new Node(value);
                return;
            }

            Node newNode = Tail;
            Tail = new(value);
            newNode.Next = Tail;
        }

        public void InsertAfter(int target, int value)
        {
            if (Head is null)
                throw new InvalidOperationException("List is null");

            Node? current = Head;
            while (current.Next != null)
            {
                if (current.DataOfNote != target)
                    current = current.Next;
                else
                {
                    Node insertNode = new(value)
                    {
                        Next = current.Next
                    };
                    current.Next = insertNode;
                    current = insertNode.Next;
                }
            }
        }

        public void RemoveHead()
        {
            if (Head == null)
                return;

            if (Head.Next is null)
            {
                Head = null;
                return;
            }

            Head = Head.Next;
        }

        public void Remove(int target)
        {
            if (Head is null)
                throw new InvalidOperationException("List is null");

            Node? current = Head;

            if (current == Tail)
            {
                Head = Tail = null;
                return;
            }
            while (current.Next != null)
            {
                if (current.Next.DataOfNote != target)
                    current = current.Next;
                else
                {
                    current.Next = current.Next.Next;
                }
            }
        }

        public void RemoveTail()
        {
            if (Head is null)
                throw new InvalidOperationException("List is null");

            Node? current = Head;

            if (current == Tail)
            {
                Head = Tail = null;
                return;
            }

            while (current != null)
            {
                if (current.Next == Tail)
                {
                    Tail = current;
                    current.Next = null;
                    return;
                }
                current = current.Next;
            }
        }

        public Node GetHead()
        {
            if (Head == null)
                throw new InvalidOperationException("List is null");

            return Head;
        }

        public Node GetTail()
        {
            if (Tail == null)
                throw new InvalidOperationException("List is null");

            return Tail;
        }

        public Node GetNode(int index)
        {
            if (Head is null)
                throw new InvalidOperationException("List is null");

            if (index == 0)
                return Head;

            Node? current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
                if (current is null)
                    throw new InvalidOperationException("Invalid index.");
            }

            return current;
        }

        public Node Search(int value)
        {
            if (Head is null)
                throw new InvalidOperationException("List is null");

            Node current = Head;
            while (current != null)
            {
                if (current.DataOfNote == value)
                    return current;
                current = current.Next;
            }
            return null;
        }

        public bool IsEmpty()
        {
            if (Head is null)
                return true;
            return false;
        }

        public void Clear()
        {
            Head = Tail = null;
        }

        public void Traverse()
        {
            if (Head is null)
                throw new InvalidOperationException("List is null");

            Node current = Head;
            while (current != null)
            {
                Console.WriteLine(current.DataOfNote);
                current = current.Next;
            }
        }

        public int Count()
        {
            if (Head is null)
                return 0;

            Node? current = Head;
            int count = 0;
            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }
    }
}
