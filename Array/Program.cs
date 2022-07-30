using System;
using System.Collections.Generic;
using System.Linq;

namespace Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Creates MyArray
            //CreateArray();

            //Reverse a string
            //Console.WriteLine(Reverse("ab"));

            //Merge sorted arrays
            //int[] arr1 = { 1, 3, 5, 7 };
            //int[] arr2 = { 2, 4, 6, 8 };
            //int[] result = MergeSortedArrays(arr1, arr2);

            //Console.WriteLine("After merge the result is");

            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}

            //KClosestElements
            int[] arr = { 1, 3, 6, 7, 10 };
            arr = KClosestElements(arr, 2, 2);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        private static int[] KClosestElements(int[] arr, int k, int x)
        {
            int len = arr.Length;
            int[] result = new int[k];
            int index = 0;
            int mid = len / 2;
            int left = mid - 1;
            int right = mid;
            int ld; int rd;

            while(left >= 0 && right < len)
            {
                ld = x - arr[left];
                rd = x - arr[right];

                if (rd < ld)
                {
                    result[index++] = arr[right++];
                }
                else if (rd > ld)
                {
                    result[index++] = arr[left++];
                }
                else if (ld == rd)
                {
                    result[index++] = arr[left++];
                    _ = (k - index) == 1 ? result[index++] = arr[right++] : right++;
                }

                if (index == k)
                    index = 0;
            }

            return result;
        }

        #region MergeArrays
        private static int[] MergeSortedArrays(int[] arr1, int[] arr2)
        {
            int a1 = arr1.Length;
            int index1 = 0;

            int a2 = arr2.Length;
            int index2 = 0;

            int[] result = new int[a1 + a2];
            int rindex = 0;

            while(index1 < a1 && index2 < a2)
            {
                if (arr1[index1] < arr2[index2])
                    result[rindex++] = arr1[index1++];
                else 
                    result[rindex++] = arr2[index2++];
            }

            while (index1 < a1)
                result[rindex++] = arr1[index1++];

            while(index2 < a2)
                result[rindex++] = arr2[index2++];

            return result;
        }
        #endregion

        #region MyArray
        public static void CreateArray()
        {
            MyArray<string> myArray = new MyArray<string>();

            myArray.push("Hello");
            myArray.push("World");
            myArray.push("!");

            for (int i = 0; i < myArray.length; i++)
            {
                Console.Write(myArray.get(i) + " ");
            }

            Console.WriteLine("After pop and delete");

            myArray.pop();

            myArray.delete(1);

            myArray.push("bhim");

            for (int i = 0; i < myArray.length; i++)
            {
                Console.Write(myArray.get(i) + " ");
            }

            Console.WriteLine(myArray[0]);
        }
        #endregion

        #region StringReversal
        public static string Reverse(string input)
        {
            int length = input.Length;
            if (string.IsNullOrEmpty(input) || length < 2) return input;

            string reverse = string.Empty;
            for (int index = length - 1; index >= 0; index--)
            {
                reverse += input[index];
            }

            /*char[] charArray = input.ToCharArray();
            System.Array.Reverse(charArray);
            reverse = new string(charArray);*/

            return reverse;
        }
        #endregion
    }
}
