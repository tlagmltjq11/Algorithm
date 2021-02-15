using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1932
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] triangle = new int[n][]; //가변배열
            int[][] cache = new int[n][];

            for (int i=0; i<n; i++)
            {
                string[] read = Console.ReadLine().Split(" ");

                triangle[i] = new int[read.Length];
                cache[i] = new int[read.Length];

                for(int j=0; j<read.Length; j++)
                {
                    triangle[i][j] = int.Parse(read[j]);
                    cache[i][j] = int.Parse(read[j]);
                }
            }

            for(int i=0; i<n-1; i++)
            {
                for(int j=0; j<triangle[i].Length; j++)
                {
                    int left = triangle[i][j] + cache[i + 1][j];
                    int right = triangle[i][j] + cache[i + 1][j + 1];

                    if(left > triangle[i + 1][j])
                    {
                        triangle[i + 1][j] = left;
                    }

                    if(right > triangle[i + 1][j + 1])
                    {
                        triangle[i + 1][j + 1] = right;
                    }
                }
            }

            int max = 0;

            for(int i=0; i<triangle[n-1].Length; i++)
            {
                if (triangle[n-1][i] > max)
                {
                    max = triangle[n-1][i];
                }
            }

            Console.WriteLine(max);
        }
    }
}
