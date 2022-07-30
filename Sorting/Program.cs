using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 38, 27, 43, 3, 9, 82, 10 };

            MergeSort merge = new MergeSort();
            merge.Merge(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
