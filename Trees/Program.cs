using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplementBST();
        }

        public static void ImplementBST()
        {
            BinarySearchTree bst = new BinarySearchTree(42);

            bst.Insert(19);
            bst.Insert(2);
            bst.Insert(20);
            bst.Insert(94);
            bst.Insert(46);
            bst.Insert(98);
            bst.Insert(83);
            bst.Insert(65);
            bst.Insert(70);

            bst.Remove(19);
            bst.Insert(44);
            bst.Remove(46);
            bst.Remove(65);
            bst.Remove(42);
            bst.Remove(2);
            bst.Remove(20);
            bst.Remove(44);
            bst.Inorder(bst.Root);
        }
    }
}
