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
            data = new int[51];
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

    class _9012
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for(int i=0; i<n; i++)
            {
                Stack_ stack = new Stack_();
                string read = Console.ReadLine();

                bool check = true;
                for(int j=0; j<read.Length; j++)
                {
                    if(read[j].Equals('('))
                    {
                        stack.push(1);
                    }
                    else
                    {
                        //가장 최근에 열린 괄호와 만나 닫혀야 하기 때문에 스택사용
                        if(stack.peek() == 1)
                        {
                            stack.pop();
                        }
                        else
                        {
                            check = false;
                            break;
                        }
                    }
                }

                if(check && stack.size() == 0)
                {
                    sb.AppendLine("YES");
                }
                else
                {
                    sb.AppendLine("NO");
                }

                
            }

            Console.WriteLine(sb.ToString());
        }
    }
    */
}
