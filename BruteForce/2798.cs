using System;
using System.Collections.Generic;
using System.Text;


namespace CodingTestPractice
{
    //Brute Force
    //카드 3장을뽑는 모든 경우의 수를 돌 수 있게 3중포문을 짜는것이 주 문제.
    class _2798
    {
        static void Main()
        {
            string[] NM = Console.ReadLine().Split(" ");
            int N = int.Parse(NM[0]);
            int M = int.Parse(NM[1]);

            string[] data = Console.ReadLine().Split(" ");
            int[] nums = Array.ConvertAll(data, s => int.Parse(s));

            int result = 0;

            for(int i=0; i<N-2; i++)
            {
                for(int j=i+1; j<N-1; j++)
                {
                    for(int k=j+1; k<N; k++)
                    {
                        int temp = (nums[i] + nums[j] + nums[k]);

                        if (temp <= M && result < temp)
                        {
                            result = temp;
                        }
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
