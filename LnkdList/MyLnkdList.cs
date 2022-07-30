using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnkdList
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
    class MyLnkdList
    {
        private Node _head;
        private Node _tail;
        private int len;

        public MyLnkdList(int value)
        {
            _head = new Node(value);
            _tail = _head;
            len = 1;
        }

        public void Append(int value)
        {
            Node temp = new Node(value);
            _tail.Next = temp;
            _tail = temp;
            len++;
            print();
        }

        public void Prepend(int value)
        {
            Node temp = new Node(value);
            temp.Next = _head;
            _head = temp;
            len++;
            print();
        }

        public bool Insert(int index, int value)
        {
            index = Wrap(index);
            if (index == 0)
            {
                Prepend(value);
                return true;
            }
            else if (index == len)
            {
                Append(value);
                return true;
            }

            Node temp = new Node(value);
            Node ittr = TraverseToIndex(index - 1);

            temp.Next = ittr.Next;
            ittr.Next = temp;
            len++;

            print();
            return true;
        }

        public void Remove(int index)
        {
            index = Wrap(index);
            if (index == 0)
            {
                _head = _head.Next;
                len--;
                print();
                return;
            }

            Node ittr = TraverseToIndex(index - 1);
            ittr.Next = ittr.Next.Next;

            len--;
            print();
        }

        public void Reverse()
        {
            if(_head.Next == null)
            {
                return;
            }

            Node first = _head;
            Node second = _head.Next;
            while(second != null)
            {
                Node temp = second.Next;
                second.Next = first;
                first = second;
                second = temp;
            }
            _head.Next = null;
            _head = first;

            print();
        }

        private int Wrap(int index)
        {
            return Math.Max(Math.Min(index, len), 0);
        }

        public Node TraverseToIndex(int index)
        {
            Node ittr = _head;

            for (int i = 0; i < index; i++)
            {
                ittr = ittr.Next;
            }
            return ittr;
        }

        public void print()
        {
            if (_head == null)
            {
                return;
            }
            Node current = _head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
