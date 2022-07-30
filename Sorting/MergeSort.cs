using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class MergeSort
    {
        public void Merge(int[] array, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            
            int mid = (left + right) / 2;
            Merge(array, left, mid);
            Merge(array, mid + 1, right);

            Sort(array,left,right,mid);
        }

        private void Sort(int[] arr, int left, int right, int mid)
        {
            int[] temp = new int[right + 1 - left];
            int first = left;
            int second = mid + 1;
            int index = 0;

            while(first<=mid && second <= right)
            {
                if (arr[first] < arr[second]){
                    temp[index++] = arr[first++];
                }
                else
                {
                    temp[index++] = arr[second++];
                }
            }

            while(first <= mid)
            {
                temp[index++] = arr[first++];
            }
            while(second <= right)
            {
                temp[index++] = arr[second++];
            }

            for (int i = 0; i < temp.Length; i++)
            {
                arr[left++] = temp[i];
            }
        }
    }
}
