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

    class _1874
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            Stack_ stack = new Stack_();
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i=0; i<n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            int cur = 1;
            int output = 0;
            bool check = false;
            while(output < n)
            {
                if(nums[output] >= cur)
                {
                    sb.AppendLine("+");
                    stack.push(cur);
                    cur++;
                }
                else
                {
                    if (stack.peek() == nums[output])
                    {
                        sb.AppendLine("-");
                        stack.pop();
                        output++;
                    }
                    else
                    {
                        check = true;
                        Console.WriteLine("NO");
                        break;
                    }
                }
            }

            if(!check)
            {
                Console.WriteLine(sb.ToString());
            }

        }
    }
    */
}
