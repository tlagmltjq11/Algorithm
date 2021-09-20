using System;
using System.Collections.Generic;

namespace CodingTestPractice
{
    class _16928
    {
        static void Main()
        {
            int[] board = new int[101];
            string[] _input = Console.ReadLine().Split(" ");

            int n = int.Parse(_input[0]);
            int m = int.Parse(_input[1]);
            int from, to;

            for (int i = 0; i < n; i++)
            {
                _input = Console.ReadLine().Split(" ");
                from = int.Parse(_input[0]);
                to = int.Parse(_input[1]);

                board[from] = to;
            }

            for (int i = 0; i < m; i++)
            {
                _input = Console.ReadLine().Split(" ");
                from = int.Parse(_input[0]);
                to = int.Parse(_input[1]);

                board[from] = to;
            }

            bool[] visited = new bool[101];
            Queue<KeyValuePair<int, int>> q = new Queue<KeyValuePair<int, int>>();
            q.Enqueue(new KeyValuePair<int, int>(1, 0));
            visited[1] = true;

            while (q.Count != 0)
            {
                KeyValuePair<int, int> cur = q.Dequeue();

                if (cur.Key == 100)
                {
                    Console.WriteLine(cur.Value);
                    break;
                }

                for(int i=1; i<=6; i++)
                {
                    int next = cur.Key + i;

                    if(next > 100)
                    {
                        break;
                    }

                    if(visited[next] == true)
                    {
                        continue;
                    }

                    visited[next] = true;

                    if(board[next] != 0)
                    {
                        next = board[next];

                        if(!visited[next])
                        {
                            q.Enqueue(new KeyValuePair<int, int>(next, cur.Value + 1));
                            visited[next] = true;
                        }
                    }
                    else
                    {
                        q.Enqueue(new KeyValuePair<int, int>(next, cur.Value + 1));
                    }
                }
            }
        }
    }
}
