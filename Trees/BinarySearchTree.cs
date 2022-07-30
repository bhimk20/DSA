using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(int value)
        {
            Root = new Node(value);
        }

        public void Insert(int value)
        {
            Node temp = new Node(value);
            if(Root == null)
            {
                Root = temp;
                return;
            }
            Node itr = Root;

            while(itr != null)
            {
                if(value < itr.Value)
                {
                    if (itr.Left == null)
                    {
                        itr.Left = temp;
                        break;
                    }
                    itr = itr.Left;
                }
                else
                {
                    if (itr.Right == null)
                    {
                        itr.Right = temp;
                        break;
                    }
                    itr = itr.Right;
                }
            }
        }

        public Node LookUp(int value)
        {
            if (Root == null)
                return null;

            Node itr = Root;

            while (itr != null)
            {
                if (value < itr.Value)
                {
                    itr = itr.Left;
                }
                else if(value > itr.Value)
                {
                    itr = itr.Right;
                }
                else
                {
                    return itr;
                }
            }
            return null;
        }

        public void Remove(int value)
        {
            //Parent node of the removal node
            Node parentNode = null;
            Node removalNode = FindNodeForRemoval(ref parentNode, value);

            if (removalNode == null)
                return;

            //No child nodes
            if(removalNode.Left == null && removalNode.Right == null)
            {
                RemoveChildNode(parentNode, removalNode);
            }
            //If containes only one child node
            else if ((removalNode.Left != null && removalNode.Right == null) || (removalNode.Left == null && removalNode.Right != null))
            {
                ReplaceParentsChildNode(parentNode, removalNode);
            }
            // Find the successor to insert in a place
            else
            {
                Node successor = SuccessorForRemoval(removalNode);

                if(parentNode == null)
                {
                    Root = successor;
                    return;
                }
                else if (parentNode.Left == removalNode)
                {
                    parentNode.Left = successor;
                }
                else
                {
                    parentNode.Right = successor;
                }
            }
        }

        private Node FindNodeForRemoval(ref Node parentNode, int value)
        {
            Node itr = Root;

            while (itr != null && itr.Value != value)
            {
                parentNode = itr;
                if (value < itr.Value)
                {
                    itr = itr.Left;
                }
                else if (value > itr.Value)
                {
                    itr = itr.Right;
                }
            }
            return itr;
        }

        private void RemoveChildNode(Node parentNode, Node removalNode)
        {
            if (parentNode == null)
            {
                Root = null;
            }
            else if (parentNode.Left == removalNode)
            {
                parentNode.Left = null;
            }
            else
            {
                parentNode.Right = null;
            }
        }

        private void ReplaceParentsChildNode(Node parentNode, Node removalNode)
        {
            if(parentNode == null)
            {
                Root = removalNode.Left != null ? removalNode.Left : removalNode.Right;
            }
            else if (parentNode.Left == removalNode)
            {
                parentNode.Left = removalNode.Left != null ? removalNode.Left : removalNode.Right;
            }
            else
            {
                parentNode.Right = removalNode.Left != null ? removalNode.Left : removalNode.Right;
            }
        }

        private Node SuccessorForRemoval(Node removalNode)
        {
            Node successor = removalNode.Right;

            while (successor.Left != null)
            {
                Node temp = successor;
                successor = successor.Left;
                if (successor.Left == null)
                {
                    temp.Left = successor.Right != null ? successor.Right : null;
                    successor.Right = removalNode.Right;
                    break;
                }
            }
            successor.Left = removalNode.Left;
            return successor;
        }

        public void Inorder(Node node)
        {
            if(node == null)
            {
                return;
            }
            Inorder(node.Left);
            Console.WriteLine(node.Value);
            Inorder(node.Right);
        }
    }
}
