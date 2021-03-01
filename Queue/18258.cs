using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class Queue_
    {
        private const int size = 2000001;

        private int[] data;
        private int front;
        private int rear;

        public Queue_()
        {
            data = new int[size];
            front = rear = 0;
        }

        public void Push(int x)
        {
            rear = (rear + 1) % size;
            data[rear] = x;
        }

        public int Pop()
        {
            if(isEmpty() == 1)
            {
                return -1;
            }
            else
            {
                front = (front + 1) % size;
                return data[front];
            }
        }

        public int Size()
        {
            return rear - front;
        }

        public int isEmpty()
        {
            if(front == rear)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int isFull()
        {
            if((rear + 1) % size == front)
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
                return data[(front + 1) % size];
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
                return data[rear];
            }
        }
    }

    class _18258
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Queue_ q = new Queue_();
            StringBuilder sb = new StringBuilder();

            for(int i=0; i<n; i++)
            {
                string[] read = Console.ReadLine().Split(" ");

                switch (read[0])
                {
                    case "push":
                        q.Push(int.Parse(read[1]));
                        break;
                    case "pop":
                        sb.AppendLine(q.Pop().ToString());
                        break;
                    case "front":
                        sb.AppendLine(q.Front().ToString());
                        break;
                    case "back":
                        sb.AppendLine(q.Back().ToString());
                        break;
                    case "size":
                        sb.AppendLine(q.Size().ToString());
                        break;
                    case "empty":
                        sb.AppendLine(q.isEmpty().ToString());
                        break;
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
    */
}
