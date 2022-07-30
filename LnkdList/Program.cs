using System;

namespace LnkdList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print a pyramid
            //PatternPrinting(15);

            //Single Linked list
            SingleLnkdList();

            //int[] arr = { 5, 2, -1, 6, -2, 7, 3 };
            //Console.WriteLine(SlidingWindow(arr,3));


            //DoubleLinkedList
            //DoubleLnkdList();

        }


        #region DoubleLnkdList
        private static void DoubleLnkdList()
        {
            DoubleLnkdList d = new DoubleLnkdList(10);
            d.Append(7);
            d.Append(16);
            d.Prepend(5);
            d.Insert(1, 99);
            d.Remove(1);

            d.Reverse();
        }

        #endregion

        #region SlidingWindow
        public static int SlidingWindow(int[] arr,int input)
        {
            int len = arr.Length;
            if (input >= len)
                return -1;

            int sum = 0;
            int result = 0;

            for(int index = 0; index < input; index++)
            {
                sum += arr[index];
            }
            result = sum;

            for (int index = input; index < len; index++)
            {
                sum = (sum - arr[index - input]) + arr[index];
                result = result < sum ? sum : result;
            }
            return result;
        }
        #endregion

        #region PrintPyramid
        public static void PatternPrinting(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                int j = 0;
                while (j < (input - i))
                {
                    Console.Write(" ");
                    j++;
                }
                for (j = 0; j < (2 * i) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Single linked list
        public static void SingleLnkdList()
        {

            MyLnkdList lnkdList = new MyLnkdList(10);
            lnkdList.Insert(0, 20);
            lnkdList.Insert(2, 5);
            lnkdList.Insert(1, 15);
            lnkdList.Insert(-1, 30);
            lnkdList.Insert(5, 2);
            //lnkdList.Append(5);
            //lnkdList.Prepend(1);
            //lnkdList.Insert(2, 9);
            //lnkdList.Insert(0, 0);
            //lnkdList.Insert(5, 3);
            //lnkdList.Insert(4, 7);
            //lnkdList.Insert(-1, -1);

            //lnkdList.Remove(-1);

            //lnkdList.Reverse();
        }
        #endregion
    }
}
