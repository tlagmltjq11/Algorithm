using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 괄호_회전하기
    {
        static bool Check(string str)
        {
            Stack<char> stack = new Stack<char>();

            for(int i=0; i<str.Length; i++)
            {
                if (str[i].Equals('(') || str[i].Equals('{') || str[i].Equals('['))
                {
                    stack.Push(str[i]);
                }
                else
                {
                    if(stack.Count == 0)
                    {
                        return false;
                    }

                    char temp = stack.Pop();

                    if(str[i].Equals(')'))
                    {
                        if(!temp.Equals('('))
                        {
                            return false;
                        }
                    }
                    else if(str[i].Equals('}'))
                    {
                        if (!temp.Equals('{'))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (!temp.Equals('['))
                        {
                            return false;
                        }
                    }
                }
            }

            if(stack.Count != 0)
            {
                return false;
            }

            return true;
        }

        static int solution(string s)
        {
            int answer = 0;

            //회전
            for(int i=0; i<s.Length; i++)
            {
                char first = s[0];
                s = s.Substring(1) + first;

                if(Check(s))
                {
                    answer++;
                }
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution("({)}"));
        }
    }
}
