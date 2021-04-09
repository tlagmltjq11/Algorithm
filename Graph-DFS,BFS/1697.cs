using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1697
    {
        static bool[] visited = new bool[100001];
        static int k;

        static int BFS(int start)
        {
            Queue<KeyValuePair<int, int>> q = new Queue<KeyValuePair<int, int>>();
            q.Enqueue(new KeyValuePair<int, int>(start, 0));
            visited[start] = true;

            while(q.Count != 0)
            {
                KeyValuePair<int, int> temp = q.Dequeue();

                if(temp.Key == k) //동생을 찾은 경우 시간 반환
                {
                    return temp.Value;
                }

                if((temp.Key - 1) >= 0 && visited[temp.Key - 1] == false)
                {
                    visited[temp.Key - 1] = true;
                    q.Enqueue(new KeyValuePair<int, int>(temp.Key - 1, temp.Value + 1));
                }

                if((temp.Key + 1) <= 100000 && visited[temp.Key + 1] == false)
                {
                    visited[temp.Key + 1] = true;
                    q.Enqueue(new KeyValuePair<int, int>(temp.Key + 1, temp.Value + 1));
                }

                if((temp.Key * 2) <= 100000 && visited[temp.Key * 2] == false)
                {
                    visited[temp.Key * 2] = true;
                    q.Enqueue(new KeyValuePair<int, int>(temp.Key * 2, temp.Value + 1));
                }
            }

            return -1;
        }

        static void Main()
        {
            string[] read = Console.ReadLine().Split(" ");
            int n = int.Parse(read[0]);
            k = int.Parse(read[1]);

            Console.WriteLine(BFS(n));
        }
    }
}
