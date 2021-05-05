using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 최솟값_만들기
    {
        static int solution(int[] A, int[] B)
        {
            int answer = 0;

            Array.Sort(A);
            Array.Sort(B);
            Array.Reverse(B);

            for(int i=0; i<A.Length; i++)
            {
                answer += (A[i] * B[i]);
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(new int[] { 1, 4, 2 }, new int[] { 5, 4, 4 }));
        }
    }
}
