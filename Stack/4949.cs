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
            data = new int[200];
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

    class _4949
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            while(true)
            {
                Stack_ stack = new Stack_();

                string read = Console.ReadLine();

                if(read.Equals("."))
                {
                    break;
                }
                
                bool check = true;
                for(int i=0; i<read.Length; i++)
                {
                    if(read[i].Equals('('))
                    {
                        stack.push(1); //1은 (
                    }
                    else if(read[i].Equals('['))
                    {
                        stack.push(2); //2는 [
                    }
                    else if(read[i].Equals(')'))
                    {
                        if(stack.peek().Equals(1))
                        {
                            stack.pop();
                        }
                        else
                        {
                            check = false;
                            break;
                        }
                    }
                    else if(read[i].Equals(']'))
                    {
                        if (stack.peek().Equals(2))
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
                    sb.AppendLine("yes");
                }
                else
                {
                    sb.AppendLine("no");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
    */
}
