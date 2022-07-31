using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries
{
    internal class Node
    {
        Node[] links = new Node[26];
        bool flag = false;

        public bool ContainsChar(char ch)
        {
            return links[ch - 'a'] is not null;
        }

        public void Insert(char ch, Node node)
        {
            links[ch - 'a'] = node;
        }

        public Node Get(char ch)
        {
            return links[ch - 'a'];
        }

        public void SetEnd()
        {
            this.flag = true;
        }

        public bool IsEnd()
        {
            return this.flag;
        }
    }
}
