using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class MyArray<T>
    {
        public int length;
        private T[] data;

        public MyArray()
        {
            this.length = 0;
            this.data = new T[1];
        }

        public T this[int index]
        {
            get
            {
                return data[index];
            }
        }

        public T get(int index)
        {
            return data[index];
        }

        public T[] push(T item)
        {
            if (this.data.Length == this.length)
            {
                T[] temp = new T[this.length + 1]; 
                System.Array.Copy(this.data, temp, length);
                data = temp;
            }
            this.data[this.length] = item;
            this.length++;
            return this.data;
        }

        public T pop()
        {
            T poped = data[this.length - 1];
            this.data[this.length - 1] = default(T); 
            this.length--;        
            return poped;
        }

        public T delete(int index)
        {
            T itemToDelete = data[index];
            shiftItems(index); 
            return itemToDelete;
        }

        private void shiftItems(int index)
        {
            for (int i = index; i < length - 1; i++)
            {
                data[i] = data[i + 1];
            }
            data[length - 1] = default(T);
            length--;
        }
    }
}
