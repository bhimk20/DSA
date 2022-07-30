using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class ArrayStack
    {
        private ArrayList _array = new ArrayList();

        public ArrayStack()
        {
        }

        public ArrayStack(int value)
        {
            _array.Add(value);
            printStack();
        }

        public void Push(int value)
        {
            _array.Add(value);
            printStack();
        }

        public void Pop()
        {
            if(_array.Count == 0)
            {
                return;
            }

            _array.RemoveAt(_array.Count - 1);
            printStack();
        }

        public int Peek()
        {
            if (_array.Count == 0)
            {
                return -1;
            }

            return (int)_array[_array.Count - 1];
        }

        public void printStack()
        {
            for (int i = _array.Count - 1; i >= 0; i--)
            {
                Console.Write("<--"+_array[i]);
            }
            Console.WriteLine();
        }
    }
}
