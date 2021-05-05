using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 다음_큰_숫자
    {
        static int solution(int n)
        {
            int answer = 0;
            int oneCnt = 0;
            int temp = n;

            while(temp > 0)
            {
                if(temp % 2 == 1)
                {
                    oneCnt++;
                }

                temp /= 2;
            }

            while(true)
            {
                n++;

                temp = n;
                int cnt = 0;
                while(temp > 0)
                {
                    if(temp % 2 == 1)
                    {
                        cnt++;
                    }

                    temp /= 2;
                }

                if(oneCnt == cnt)
                {
                    return n;
                }
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(78));
        }
    }
}
