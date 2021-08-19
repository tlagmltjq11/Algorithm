using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 숫자_게임
    {
        static int solution(int[] A, int[] B)
        {
            int answer = 0;

            Array.Sort(A);
            Array.Sort(B);

            int iterA = A.Length -1;
            int iterB = B.Length -1;

            while(iterA >= 0)
            {
                if(B[iterB] > A[iterA])
                {
                    answer++;
                    iterB--;
                }
                iterA--;
            }

            return answer;
        }

        static void Main()
        {
            Console.Write(solution(new int[] {5,1,3,7 }, new int[] {2,2,6,8 }));
        }
    }
}
