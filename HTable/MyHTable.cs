using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTable
{
    class MyNode
    {
        public string Key { get; set; }
        public int Value { get; set; }

        public MyNode(string key, int value)
        {
            Key = key;
            Value = value;
        }
    }

    

    class MyHTable
    {
        private class MyNodes : List<MyNode> { }
        private int _length;
        private MyNodes[] _data;
        

        public MyHTable(int size)
        {
            _length = size;
            _data = new MyNodes[size];
        }

        private int Hash(string key)
        {
            int hash = 0;
                
            for(int index = 0; index<key.Length; index++)
            {
                hash = (hash + (int)key[index] * index) % _length;
            }

            return hash;
        }

        public void Set(string key, int value)
        {
            int index = Hash(key);
            if (_data[index] == null)
            {
                _data[index] = new MyNodes();
            }
            _data[index].Add(new MyNode(key, value));
        }

        public int Get(string key)
        {
            int index = Hash(key);
            if (_data[index] == null)
            {
                return 0;
            }
            foreach (var node in _data[index])
            {
                if (node.Key.Equals(key))
                {
                    return node.Value;
                }
            }
            return 0;
        }

        public List<string> Keys()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i] != null)
                {
                    for (int j = 0; j < _data[i].Count; j++)
                    {
                        result.Add(_data[i][j].Key);
                        Console.WriteLine(i + " " + _data[i][j].Key);
                    }
                }
            }
            return result;
        }

    }
}
