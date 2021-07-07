using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 점프와_순간_이동
    {
        static int solution(int n)
        {
            int answer = 0;

            while(n > 0)
            {
                //나머지가 존재한다면 점프가 + 1 필요한 순간
                if(n % 2 != 0)
                {
                    answer++;
                }

                n /= 2;
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(5000));
        }
    }
}
