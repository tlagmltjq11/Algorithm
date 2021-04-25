using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class Node
    {
        public int data;
        public Node left, right;

        public Node(int d)
        {
            data = d;
            left = null;
            right = null;
        }
    }

    class BST
    {
        public Node root;
        public StringBuilder sb = new StringBuilder();

        public BST()
        {
            root = null;
        }

        public void insert(int data)
        {
            Node temp = new Node(data);
            temp.left = null;
            temp.right = null;

            if(root == null)
            {
                root = temp;
            }
            else
            {
                Node iter = root;
                Node parent;

                while(true)
                {
                    parent = iter;

                    if(iter.data > temp.data)
                    {
                        iter = iter.left;

                        if(iter == null)
                        {
                            parent.left = temp;
                            break;
                        }
                    }
                    else
                    {
                        iter = iter.right;

                        if (iter == null)
                        {
                            parent.right = temp;
                            break;
                        }
                    }
                }
            }
        }

        public void postOrder(Node root)
        {
            if(root != null)
            {
                postOrder(root.left);
                postOrder(root.right);
                sb.AppendLine(root.data.ToString());
            }
        }
    }


    class _5639
    {
        static void Main()
        {
            BST bst = new BST();

            while (true)
            {
                string temp = Console.ReadLine();

                if(temp == null || temp == string.Empty || temp == "")
                {
                    break;
                }

                bst.insert(int.Parse(temp));
            }

            bst.postOrder(bst.root);
            Console.WriteLine(bst.sb.ToString());
        }
    }
}
