using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _13904
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();

            int maxDay = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine().Split(" ");

                int d = int.Parse(temp[0]);
                int w = int.Parse(temp[1]);

                maxDay = Math.Max(maxDay, d);

                list.Add(new KeyValuePair<int, int>(d, w));
            }

            int[] greedy = new int[maxDay+1];
            list.Sort((a, b) => -a.Value.CompareTo(b.Value));

            for (int i = 0; i < n; i++)
            {
                var cur = list[i];

                for (int j = cur.Key; j > 0; j--)
                {
                    if (greedy[j] == 0)
                    {
                        greedy[j] = cur.Value;
                        break;
                    }
                }
            }

            int answer = 0;
            for(int i=1; i<maxDay+1; i++)
            {
                answer += greedy[i];
            }

            Console.WriteLine(answer);
        }
    }
}
