using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 숫자의_표현
    {
        static int solution(int n)
        {
            int answer = 1;

            for(int i=1; i<=n/2; i++)
            {
                int sum = 0;
                int iter = i;

                while(true)
                {
                    sum += iter;

                    if(sum == n)
                    {
                        answer++;
                        break;
                    }
                    else if(sum > n)
                    {
                        break;
                    }
                    else
                    {
                        iter++;
                    }
                }
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(15));
        }
    }
}
