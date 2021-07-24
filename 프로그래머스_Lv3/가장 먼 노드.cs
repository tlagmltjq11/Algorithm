using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 가장_먼_노드
    {
        static int farthest = 0;
        static int[,] matrix;
        static bool[] visited;
        static int solution(int n, int[,] edge)
        {
            int answer = 0;

            matrix = new int[n+1, n+1];
            visited = new bool[n + 1];

            for (int i=0; i<edge.GetLength(0); i++)
            {
                int start = edge[i, 0];
                int end = edge[i, 1];

                matrix[start, end] = 1;
                matrix[end, start] = 1;
            }

            Queue<KeyValuePair<int, int>> q = new Queue<KeyValuePair<int, int>>();
            q.Enqueue(new KeyValuePair<int, int>(1, 0));
            visited[1] = true;

            while(q.Count != 0)
            {
                KeyValuePair<int, int> temp = q.Dequeue();

                for(int i=1; i<n+1; i++)
                {
                    if(temp.Key == i)
                    {
                        continue;
                    }

                    if(matrix[temp.Key, i] == 1 && !visited[i])
                    {
                        visited[i] = true;
                        q.Enqueue(new KeyValuePair<int, int>(i, temp.Value + 1));

                        if(temp.Value + 1 > farthest)
                        {
                            farthest = temp.Value + 1;
                            answer = 1;
                        }
                        else if(temp.Value + 1 == farthest)
                        {
                            answer++;
                        }
                    }
                }
            }

            return answer;
        }

        static void Main()
        {
            Console.Write(solution(6, new int[,] { { 3, 6 }, { 4, 3 }, { 3, 2 }, { 1, 3 }, { 1, 2 }, { 2, 4 }, { 5, 2 } }));
        }
    }
}
