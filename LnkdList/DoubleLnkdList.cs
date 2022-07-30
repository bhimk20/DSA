using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnkdList
{
    class DoubleNode
    {
        public int Value { get; set; }
        public DoubleNode Previous { get; set; }
        public DoubleNode Next { get; set; }

        public DoubleNode(int value)
        {
            Value = value;
        }
    }

    class DoubleLnkdList
    {
        private DoubleNode _head;
        private DoubleNode _tail;
        private int len;

        public DoubleLnkdList(int value)
        {
            _head = new DoubleNode(value);
            _tail = _head;
            len = 1;
        }

        public void Append(int value)
        {
            DoubleNode temp = new DoubleNode(value);
            temp.Previous = _tail;
            _tail.Next = temp;
            _tail = temp;
            len++;
            print();
        }

        public void Prepend(int value)
        {
            DoubleNode temp = new DoubleNode(value);
            temp.Next = _head;
            _head.Previous = temp;
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
            else if (index == len - 1)
            {
                Append(value);
                return true;
            }

            DoubleNode temp = new DoubleNode(value);
            DoubleNode lead = TraverseToIndex(index - 1);
            DoubleNode follower = lead.Next;
            temp.Next = follower;
            lead.Next = temp;
            temp.Previous = lead;
            follower.Previous = temp;  
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

            DoubleNode ittr = TraverseToIndex(index - 1);
            DoubleNode removed = ittr.Next;
            ittr.Next = removed.Next;
            removed.Next.Previous = ittr;

            len--;
            print();
        }

        public void Reverse()
        {
            if (_head.Next == null)
            {
                return;
            }

            DoubleNode first = _head;
            DoubleNode second = _head.Next;
            while (second != null)
            {
                DoubleNode temp = second.Next;
                first.Previous = second;
                second.Next = first;
                first = second;
                second = temp;
            }
            first.Previous = null;
            _head.Next = null;
            _head = first;

            print();
        }

        private int Wrap(int index)
        {
            return Math.Max(Math.Min(index, len - 1), 0);
        }

        public DoubleNode TraverseToIndex(int index)
        {
            DoubleNode ittr = _head;

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
            DoubleNode current = _head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
