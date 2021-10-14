using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _9019
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for(int i=0; i<t; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                Queue<KeyValuePair<int, string>> q = new Queue<KeyValuePair<int, string>>();
                bool[] visited = new bool[10000];

                q.Enqueue(new KeyValuePair<int, string>(a, ""));
                visited[a] = true;

                while(q.Count != 0)
                {
                    var cur = q.Dequeue();

                    if(cur.Key == b)
                    {
                        sb.AppendLine(cur.Value);
                        break;
                    }

                    int D, S, L, R;
                    // D 연산
                    D = (cur.Key * 2) % 10000;
                    if (!visited[D])
                    {
                        visited[D] = true;
                        q.Enqueue(new KeyValuePair<int, string>(D, cur.Value + "D"));
                    }

                    // S 연산
                    S = cur.Key - 1 < 0 ? 9999 : cur.Key - 1;
                    if (!visited[S])
                    {
                        visited[S] = true;
                        q.Enqueue(new KeyValuePair<int, string>(S, cur.Value + "S"));
                    }

                    // L 연산
                    L = (cur.Key % 1000) * 10 + (cur.Key / 1000);
                    if (!visited[L])
                    {
                        visited[L] = true;
                        q.Enqueue(new KeyValuePair<int, string>(L, cur.Value + "L"));
                    }

                    // R 연산
                    R = cur.Key / 10 + (cur.Key % 10) * 1000;
                    if (!visited[R])
                    {
                        visited[R] = true;
                        q.Enqueue(new KeyValuePair<int, string>(R, cur.Value + "R"));
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
