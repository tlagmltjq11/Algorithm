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
            data = new int[100001];
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
            if (top == -1)
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
            if (empty() == 1)
            {
                return -1;
            }
            else
            {
                return data[top];
            }
        }
    }

    class _10773
    {
        static void Main()
        {
            Stack_ stack = new Stack_();
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if(num != 0)
                {
                    stack.push(num);
                }
                else
                {
                    stack.pop();
                }
            }

            int result = 0;
            int size = stack.size();
            for (int i=0; i<size; i++)
            {
                result += stack.pop();
            }

            Console.WriteLine(result);
        }
    }
    */
}
