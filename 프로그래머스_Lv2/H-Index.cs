using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class H_Index
    {
        static int solution(int[] citations)
        {
            int answer = 0;

            Array.Sort(citations);

            if(citations[citations.Length-1] == 0)
            {
                return 0;
            }

            for(int i=citations.Length-1; i>=0; i--)
            {
                if (citations[i] > answer)
                {
                    answer++;
                }
                else
                {
                    break;
                }
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(new int[] {3,0,6,1,5 }));
        }
    }
}
