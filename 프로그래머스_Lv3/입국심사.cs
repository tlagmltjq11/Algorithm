using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 입국심사
    {
        static long solution(int n, int[] times)
        {
            long answer = 0;

            Array.Sort(times);
            long min = 1;
            long max = (long)times[times.Length - 1] * (long)n; //제일 오래 걸리는 심사관에서 모두 심사할 경우가 최대 시간
            answer = max;

            while(min <= max)
            {
                long mid = (min + max) / 2;
                long sum = 0;

                for(int i=0; i<times.Length; i++)
                {
                    sum += (mid / times[i]); 
                }

                //mid 시간 안에 모든 심사가 가능한 경우
                if(sum >= n)
                {
                    if(answer > mid)
                    {
                        answer = mid;
                    }

                    max = mid - 1; //시간을 줄여봄
                }
                else
                {
                    min = mid + 1; //시간을 늘려봄
                }
            }

            return answer;
        }

        static void Main()
        {
            long result = solution(6, new int[] { 7, 10 });
            Console.Write(result);
        }
    }
}
