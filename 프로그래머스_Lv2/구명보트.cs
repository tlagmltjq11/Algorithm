using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 구명보트
    {
        static int solution(int[] people, int limit)
        {
            int answer = 0;

            Array.Sort(people);

            int left = 0;
            int right = people.Length - 1;

            while(left < right)
            {
                if(people[left] + people[right] <= limit)
                {
                    answer++;
                    left++;
                    right--;
                }
                else
                {
                    answer++;
                    right--;
                }
            }

            if(left == right)
            {
                answer++;
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(new int[] { 70, 50, 80, 50 }, 100));
        }
    }
}
