using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 모두_0으로_만들기
    {
        static List<int>[] matrix;
        static int size;
        static long[] aa;
        static long answer;
        static bool[] visited;

        static long DFS(int cur)
        {
            for(int i=0; i<matrix[cur].Count; i++)
            {
                if(visited[matrix[cur][i]] != true)
                {
                    visited[matrix[cur][i]] = true;
                    long temp = DFS(matrix[cur][i]);
                    aa[cur] += temp;
                    answer += Math.Abs(temp);
                }
            }

            return aa[cur];
        }

        static long solution(int[] a, int[,] edges)
        {
            answer = 0;
            size = a.Length;
            visited = new bool[size];
            matrix = new List<int>[size];
            aa = new long[size];

            for(int i=0; i<size; i++)
            {
                matrix[i] = new List<int>();
                aa[i] = (long)a[i];
            }

            //트리 연결
            for(int i=0; i<edges.GetLength(0); i++)
            {
                matrix[edges[i, 0]].Add(edges[i, 1]);
                matrix[edges[i, 1]].Add(edges[i, 0]);
            }

            //최소 횟수 체크
            visited[0] = true;
            DFS(0);

            //루트노드가 0이 되지 않았다는 것은 모든 가중치를 0으로 만들지 못한다는 것
            if(aa[0] != 0)
            {
                return -1;
            }

            return answer;
        }

        static void Main()
        {
            Console.Write(solution(new int[] { -5, 0, 2, 1, 2 }, new int[,] { { 0, 1 },{ 3, 4 },{ 2, 3 },{ 0, 3 } }));
        }
    }
}
