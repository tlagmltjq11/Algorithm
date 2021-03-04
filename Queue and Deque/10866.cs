using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class Node
    {
        public int data;
        public Node link;
    }

    class Deque
    {
        public Node header, tail;
        public int curSize;

        public void Init()
        {
            header = new Node();
            tail = new Node();
            curSize = 0;
        }


        public void push_Front(int data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if(isEmpty() == 1)
            {
                header.link = newNode;
                tail.link = newNode;
                curSize++;

                return;
            }
            else
            {
                newNode.link = header.link;
                header.link = newNode;
                curSize++;

                return;
            }
        }

        public void push_Back(int data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (isEmpty() == 1)
            {
                header.link = newNode;
                tail.link = newNode;
                curSize++;

                return;
            }
            else
            {
                tail.link.link = newNode;
                tail.link = newNode;
                curSize++;

                return;
            }
        }

        public int pop_Front()
        {
            if(isEmpty() == 0)
            {
                Node delNode = header.link;
                header.link = delNode.link;

                curSize--;

                return delNode.data;
            }
            else
            {
                return -1;
            }
        }

        public int pop_Back()
        {
            if (isEmpty() == 0)
            {
                Node delNode = tail.link;

                Node iter = header.link;
                for(int i=0; i<curSize-2; i++)
                {
                    iter = iter.link;
                }

                tail.link = iter;

                curSize--;

                return delNode.data;
            }
            else
            {
                return -1;
            }
        }

        public int Size()
        {
            return curSize;
        }

        public int isEmpty()
        {
            if(curSize == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Front()
        {
            if(isEmpty() == 1)
            {
                return -1;
            }
            else
            {
                return header.link.data;
            }
        }

        public int Back()
        {
            if (isEmpty() == 1)
            {
                return -1;
            }
            else
            {
                return tail.link.data;
            }
        }
    }
    
    class _10866
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            Deque dq = new Deque();
            dq.Init();

            for(int i=0; i<n; i++)
            {
                string[] read = Console.ReadLine().Split(" ");

                switch(read[0])
                {
                    case "push_front":
                        dq.push_Front(int.Parse(read[1]));
                        break;
                    case "push_back":
                        dq.push_Back(int.Parse(read[1]));
                        break;
                    case "pop_front":
                        sb.AppendLine(dq.pop_Front().ToString());
                        break;
                    case "pop_back":
                        sb.AppendLine(dq.pop_Back().ToString());
                        break;
                    case "size":
                        sb.AppendLine(dq.Size().ToString());
                        break;
                    case "empty":
                        sb.AppendLine(dq.isEmpty().ToString());
                        break;
                    case "front":
                        sb.AppendLine(dq.Front().ToString());
                        break;
                    case "back":
                        sb.AppendLine(dq.Back().ToString());
                        break;
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
    */
}
