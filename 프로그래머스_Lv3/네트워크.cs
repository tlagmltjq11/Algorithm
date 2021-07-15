using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 네트워크
    {
        static bool[] visited;
        static int size;

        static void DFS(int i, int j, int[,] network)
        {
            for (int end = j; end < size; end++)
            {
                if (i != end && visited[end] != true)
                {
                    if (network[i, end] == 1)
                    {
                        visited[end] = true;
                        DFS(end, 0, network);
                    }
                }
            }
        }

        static int solution(int n, int[,] computers)
        {
            int answer = 0;

            size = n;
            visited = new bool[n];

            for(int i=0; i<n; i++)
            {
                if(visited[i] == false)
                {
                    visited[i] = true;
                    answer++;
                    DFS(i, 0, computers);
                }
            }

            return answer;
        }

        static void Main()
        {
            Console.Write(solution(3, new int[,] { { 1, 1, 0 }, { 1, 1, 0 }, { 0, 0, 1 } }));
        }
    }
}
