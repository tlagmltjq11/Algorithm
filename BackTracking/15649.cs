using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _15649
    {
        static int N, M;
        static int[] arr = new int[9];
        static bool[] visited = new bool[9];

        static void BackTrack(int cnt)
        {
            if(cnt == M)
            {
                StringBuilder sb = new StringBuilder();

                for(int i=0; i<M; i++)
                {
                    sb.Append(arr[i] + " ");
                }

                Console.WriteLine(sb.ToString());
            }
            else
            {
                for(int i=1; i<=N; i++)
                {
                    if(!visited[i])
                    {
                        visited[i] = true;
                        arr[cnt] = i;
                        BackTrack(cnt + 1);
                        visited[i] = false;
                    }
                }
            }
        }

        static void Main()
        {
            string[] read = Console.ReadLine().Split(" ");
            N = int.Parse(read[0]);
            M = int.Parse(read[1]);

            BackTrack(0);
        }
    }
}
