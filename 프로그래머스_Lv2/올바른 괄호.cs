using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 올바른_괄호
    {
        static bool solution(string s)
        {
            bool answer = true;

            Stack<char> stack = new Stack<char>();

            for(int i=0; i<s.Length; i++)
            {
                if(s[i].Equals('('))
                {
                    stack.Push('(');
                }
                else
                {
                    if(stack.Count != 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        answer = false;
                        return answer;
                    }
                }
            }

            if(stack.Count != 0)
            {
                answer = false;
            }
            else
            {
                answer = true;
            }

            return answer;
        }

        static void Main()
        {
            bool result = solution("(()(");

            if(result)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
