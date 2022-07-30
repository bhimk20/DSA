using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack with LinkedList
            LnkdListStack();

            //Stack with ArrayList
            ArrayListStack();
        }

        #region ArrayListStack
        private static void ArrayListStack()
        {
            ArrayStack s = new ArrayStack();
            s.Push(10);
            s.Push(16);
            s.Push(100);
            s.Pop();
            Console.WriteLine(s.Peek());
        }
        #endregion

        #region LnkdListStack
        private static void LnkdListStack()
        {
            MyStack s = new MyStack();
            s.Push(10);
            s.Push(16);
            s.Push(100);
            s.Pop();
            Console.WriteLine(s.Peek());
            //s.printStack();
        }
        #endregion
    }
}
