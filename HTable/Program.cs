using System;
using System.Collections;
using System.Collections.Generic;

namespace HTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyHTable
            MyHashTable();

            //Recurring character
            // { 2, 1, 1, 2, 3, 5 }, { 2, 5, 1, 2, 3 }
            int[] arr = { 2, 5, 1, 2, 3 };
            //Console.WriteLine(RecurringCharacter(arr));
        }

        private static int RecurringCharacter(int[] arr)
        {
            if (arr == null || arr.Length == 1)
                return -1;
            int len = arr.Length;

            //O(n^2)
            /*for(int indx = 1; indx < len; indx++)
            {
                for(int innerIndx = indx - 1; innerIndx >= 0; innerIndx--)
                {
                    if (arr[indx] == arr[innerIndx])
                        return arr[indx];
                }
            }*/

            Hashtable ht = new Hashtable(len);
            for (int indx = 0; indx < len; indx++)
            {
                if (ht.ContainsKey(arr[indx]))
                    return arr[indx];
                ht.Add(arr[indx], indx);
            }

            return -1;
        }

        #region MyHashTable
        public static void MyHashTable()
        {
            MyHTable h = new MyHTable(2);
            h.Set("grapes", 1000);
            h.Set("apples", 54);
            h.Set("apples", 1000);
            Console.WriteLine(h.Get("apples"));
            h.Keys();
            Console.WriteLine(h.Get("apples"));
        }
        #endregion
    }
}
