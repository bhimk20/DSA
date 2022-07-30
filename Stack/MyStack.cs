using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
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
    class MyStack
    {
        private Node _top = null;
        private Node _bottom = null;
        private int _length = 0;

        public MyStack()
        {
           
        }
        public MyStack(int value)
        {
            _top = new Node(value);
            _bottom = new Node(value);
            _length++;
            printStack();
        }

        public void Pop()
        {
            if (_top == null)
            {
                return;
            }
            if(_top == _bottom)
            {
                _bottom = null;
            }
            _top = _top.Next;
            _length--;
            printStack();
        }

        public void Push(int value)
        {
            Node temp = new Node(value);
            if(_length == 0)
            {
                _top = temp; _bottom = temp;
            }
            else
            {
                Node pointer = _top;
                _top = temp;
                _top.Next = pointer;
            }
            _length++;
            printStack();
        }

        public int Peek()
        {
            return _top.Value;
        }

        public void printStack()
        {
            if (_top == null)
            {
                return;
            }
            Node currentNode = _top;
            Console.Write(currentNode.Value);
            currentNode = currentNode.Next;
            while (currentNode != null)
            {
                Console.Write("<--" + currentNode.Value);
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
    }
}
