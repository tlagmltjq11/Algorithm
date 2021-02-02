using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _15652
    {

        static int N, M;
        static int[] arr = new int[8];
        static StringBuilder sb = new StringBuilder();

        static void BackTrack(int cnt, int prev)
        {
            if (cnt == M)
            {
                for (int i = 0; i < cnt; i++)
                {
                    sb.Append(arr[i] + " ");
                }
                sb.AppendLine();
            }
            else
            {
                for (int i = prev; i <= N; i++)
                {
                    arr[cnt] = i;
                    BackTrack(cnt + 1, i);
                }
            }
        }

        static void Main()
        {
            string[] read = Console.ReadLine().Split(" ");
            N = int.Parse(read[0]);
            M = int.Parse(read[1]);

            BackTrack(0, 1);
            Console.WriteLine(sb.ToString());
        }
    }
}
