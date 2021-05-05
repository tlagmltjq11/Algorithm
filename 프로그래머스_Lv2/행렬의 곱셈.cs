using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 행렬의_곱셈
    {
        static int[,] solution(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetLength(0), arr2.GetLength(1)];

            for(int i=0; i<arr1.GetLength(0); i++)
            {
                for(int j=0; j<arr2.GetLength(1); j++)
                {
                    int temp = 0;
                    for(int k=0; k<arr2.GetLength(0); k++)
                    {
                        temp += (arr1[i, k] * arr2[k, j]);
                    }

                    answer[i, j] = temp;
                }
            }

            return answer;
        }

        static void Main()
        {

        }
    }
}
