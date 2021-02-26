using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class Stack_
    {
        private int[] data;
        private int top;

        public Stack_()
        {
            data = new int[10001];
            top = -1;
        }

        public void push(int num)
        {
            top++;
            data[top] = num;
        }

        public int pop()
        {
            if (empty() == 1)
            {
                return -1;
            }
            else
            {
                return data[top--];
            }
        }

        public int size()
        {
            return top + 1;
        }

        public int empty()
        {
            if(top == -1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int peek()
        {
            if(empty() == 1)
            {
                return -1;
            }
            else
            {
                return data[top];
            }
        }
    }

    class _10828
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Stack_ stack = new Stack_();
            StringBuilder sb = new StringBuilder();

            for(int i=0; i<n; i++)
            {
                string[] read = Console.ReadLine().Split(" ");

                switch(read[0])
                {
                    case "push":
                        stack.push(int.Parse(read[1]));
                        break;

                    case "pop":
                        sb.AppendLine(stack.pop().ToString());
                        break;

                    case "size":
                        sb.AppendLine(stack.size().ToString());
                        break;

                    case "empty":
                        sb.AppendLine(stack.empty().ToString());
                        break;

                    case "top":
                        sb.AppendLine(stack.peek().ToString());
                        break;
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
    */
}
