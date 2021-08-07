using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 가장_긴_팰린드롬
    {
        static bool isPalinDrome(string str, int start, int end)
        {
            int size = start + (end - start + 1) / 2; 

            for(int i=start; i< size; i++)
            {
                if(!str[i].Equals(str[end]))
                {
                    return false;
                }
                end--;
            }

            return true;
        }

        static int solution(string s)
        {
            int answer = 0;

            for(int i=s.Length; i>=1; i--)
            {
                for(int j=0; j<=s.Length - i; j++)
                {
                    if (isPalinDrome(s, j, j + i - 1))
                    {
                        answer = i;
                        return answer;
                    }
                }
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution("abcabcdcbae"));
        }
    }
}
