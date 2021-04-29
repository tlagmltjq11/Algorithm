using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _124_나라의_숫자
    {
        static string solution(int n)
        {
            string answer = "";
            string[] numbers = { "4", "1", "2" };

            while (n > 0)
            {
                int remainder = n % 3;
                n = n / 3;

                //나누어 떨어졌을 경우 처리해줘야 할 예외 사항
                if(remainder == 0)
                {
                    n--;
                }

                answer = numbers[remainder] + answer;
            }

            return answer;
        }


        static void Main()
        {
            Console.WriteLine(solution(10));
        }
    }
}
