using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _15650
    {
        static int N, M;
        static int[] arr = new int[9];
        static bool[] visited = new bool[9];

        static void BackTrack(int cnt, int prev)
        {
            if(cnt == M)
            {
                StringBuilder sb = new StringBuilder();

                for(int i=0; i<cnt; i++)
                {
                    sb.Append(arr[i] + " ");
                }

                Console.WriteLine(sb.ToString());
            }
            else
            {
                //prev를 통해 이전에 고른값 이후부터 시작하게한다면
                //오름차순으로 고르게끔 유도할 수 있다.
                for(int i=prev; i<=N; i++)
                {
                    if(!visited[i])
                    {
                        visited[i] = true;
                        arr[cnt] = i;
                        prev = i;
                        BackTrack(cnt + 1, prev);
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

            BackTrack(0, 1);
        }
    }
}
