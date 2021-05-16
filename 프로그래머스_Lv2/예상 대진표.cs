using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 예상_대진표
    {
        static int solution(int n, int a, int b)
        {
            int answer = 1;

            int min, max;

            if(a > b)
            {
                min = b;
                max = a;
            }
            else
            {
                min = a;
                max = b;
            }

            while(true)
            {
                if(min + 1 == max && max % 2 == 0)
                {
                    break;
                }

                min = (min + 1) / 2;
                max = (max + 1) / 2;

                answer++;
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(8, 4, 7));
        }
    }
}
