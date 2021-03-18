using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _10830
    {
        static long[,] Multi(long[,] a, long[,] b)
        {
            long[,] result = new long[a.GetLength(0), b.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    long temp = 0;

                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        temp += a[i, k] * b[k, j];
                    }

                    result[i, j] = temp % 1000;
                }
            }

            return result;
        }

        static long[,] Divide(long[,] arr, long b)
        {
            if (b == 1) //분할의 끝지점.
            {
                return arr; //1제곱이니 arr 그 자체를 반환
            }

            long[,] n = Divide(arr, b / 2); //b가 1이 아니라면 2로 나눈 즉 분할한 값을 구해온다.
            long[,] temp = Multi(n, n); //구해온 값을 제곱

            if (b % 2 == 0)
            {
                return temp;
            }
            else
            {
                return Multi(arr, temp);
            }
        }

        static void Main()
        {
            long n, b;

            string[] read = Console.ReadLine().Split(" ");

            n = long.Parse(read[0]);
            b = long.Parse(read[1]);

            long[,] arr = new long[n, n];

            for (int i = 0; i < n; i++)
            {
                read = Console.ReadLine().Split(" ");

                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = long.Parse(read[j]);
                }
            }

            long[,] result = Divide(arr, b);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    sb.Append(result[i, j] + " ");
                }

                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
