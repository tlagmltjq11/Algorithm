using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1991
    {
        class Node
        {
            public char data;
            public Node left, right;

            public Node(char data)
            {
                this.data = data;
            }
        }

        class Tree
        {
            public Node root;

            public void createNode(char data, char left, char right)
            {
                if(root == null)
                {
                    root = new Node(data);

                    if (!left.Equals('.'))
                    {
                        root.left = new Node(left);
                    }

                    if (!right.Equals('.'))
                    {
                        root.right = new Node(right);
                    }
                }
                else
                {
                    searchNode(root, data, left, right);
                }
            }

            public void searchNode(Node root, char data, char left, char right)
            {
                if(root == null)
                {
                    return;
                }
                else if(root.data == data)
                {
                    if (!left.Equals('.'))
                    {
                        root.left = new Node(left);
                    }

                    if (!right.Equals('.'))
                    {
                        root.right = new Node(right);
                    }
                }
                else
                {
                    searchNode(root.left, data, left, right);
                    searchNode(root.right, data, left, right);
                }
            }

            public void preorder(Node root)
            {
                if(root != null)
                {
                    Console.Write(root.data);
                    preorder(root.left);
                    preorder(root.right);
                }
            }

            public void inorder(Node root)
            {
                if (root != null)
                {
                    inorder(root.left);
                    Console.Write(root.data);
                    inorder(root.right);
                }
            }

            public void postorder(Node root)
            {
                if (root != null)
                {
                    postorder(root.left);
                    postorder(root.right);
                    Console.Write(root.data);
                }
            }
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Tree t = new Tree();

            string[] read;
            for(int i=0; i<n; i++)
            {
                read = Console.ReadLine().Split(" ");

                t.createNode(char.Parse(read[0]), char.Parse(read[1]), char.Parse(read[2]));
            }

            t.preorder(t.root);
            Console.WriteLine();
            t.inorder(t.root);
            Console.WriteLine();
            t.postorder(t.root);
            Console.WriteLine();
        }
    }
}
