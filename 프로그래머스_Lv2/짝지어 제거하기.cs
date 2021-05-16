using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 짝지어_제거하기
    {
        static int solution(string s)
        {
            int answer = 0;

            Stack<char> st = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (st.Count == 0)
                {
                    st.Push(s[i]);
                }
                else
                {
                    if (st.Peek() == s[i])
                    {
                        st.Pop();
                    }
                    else
                    {
                        st.Push(s[i]);
                    }
                }
            }

            if (st.Count == 0)
            {
                answer = 1;
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution("cdcd"));
        }
    }
}
