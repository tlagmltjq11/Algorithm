using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class _1966
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                Queue<KeyValuePair<int, int>> q = new Queue<KeyValuePair<int, int>>();
                string[] read = Console.ReadLine().Split(" ");
                int m = int.Parse(read[0]);
                int k = int.Parse(read[1]);

                string[] priority = Console.ReadLine().Split(" ");

                if (m == 1)
                {
                    sb.AppendLine("1");
                }
                else
                {
                    for (int j = 0; j < m; j++)
                    {
                        q.Enqueue(new KeyValuePair<int, int>(j, int.Parse(priority[j])));
                    }

                    int cnt = 0;

                    while (q.Count != 0)
                    {
                        bool check = false;

                        KeyValuePair<int, int>[] arr = q.ToArray();

                        for (int j = 1; j < arr.Length; j++)
                        {
                            if (arr[0].Value < arr[j].Value)
                            {
                                check = true;
                                break;
                            }
                        }

                        if (!check)
                        {
                            cnt++;

                            if (q.Peek().Key == k)
                            {
                                sb.AppendLine(cnt.ToString());
                                break;
                            }

                            q.Dequeue();
                        }
                        else
                        {
                            q.Enqueue(q.Dequeue());
                        }
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
    */
}
