using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries
{
    public class Trie
    {
        Trie[] nodes = new Trie[26];
        bool isEnd = false;

        public void Insert(string word)
        {
            Trie node = this;
            for (int i = 0; i < word.Length; i++)
            {
                char ch = word[i];
                if (node.nodes[ch - 'a'] is null)
                { 
                    node.nodes[ch - 'a'] = new();
                }
                node = node.nodes[ch - 'a'];
            }

            node.isEnd = true;
        }

        public bool Search(string word)
        {
            Trie node = this;
            for (int i = 0; i < word.Length; i++)
            {
                char ch = word[i];
                if (node.nodes[ch - 'a'] is null)
                {
                    return false;
                }
                node = node.nodes[ch - 'a'];
            }

            return node.isEnd;
        }

        public bool StartsWith(string word)
        {
            Trie node = this;
            for (int i = 0; i < word.Length; i++)
            {
                char ch = word[i];
                if (node.nodes[ch - 'a'] is null)
                {
                    return false;
                }
                node = node.nodes[ch - 'a'];
            }

            return true;
        }

        public bool RecursiveSearch(string word)
        {
            return DFS(this, 0, word);
        }

        private bool DFS(Trie node, int index, string word)
        {
            if(node == null)
            {
                return false;
            }
            if(index == word.Length)
            {
                return node.isEnd;
            }
            char letter = word[index];
            if (letter != '.')
            {
                node = node.nodes[letter - 'a'];
                return DFS(node, (index + 1), word);
            }
            else
            {
                for(int j = 0; j < node.nodes.Length; j++)
                {
                    if(DFS(node.nodes[j], (index + 1), word))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
