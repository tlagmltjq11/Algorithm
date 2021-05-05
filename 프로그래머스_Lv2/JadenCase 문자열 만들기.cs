using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class JadenCase_문자열_만들기
    {
        static string solution(string s)
        {
            string answer = "";

            char[] arr = s.ToLower().ToCharArray();
            arr[0] = char.ToUpper(arr[0]);

            for(int i=1; i<arr.Length; i++)
            {
                if(arr[i-1] == ' ')
                {
                    arr[i] = char.ToUpper(arr[i]);
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                answer += arr[i];
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution("3people unFollowed me"));
        }
    }
}
