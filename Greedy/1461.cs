using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingTestPractice
{
    class _1461
    {
        static void Main()
        {
            string[] nm = Console.ReadLine().Split(" ");
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            int[] locations = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), (s) => int.Parse(s));

            List<int> min = new List<int>();
            List<int> plus = new List<int>();

            for(int i=0; i<n; i++)
            {
                if(locations[i] < 0)
                {
                    min.Add(locations[i]);
                }
                else
                {
                    plus.Add(locations[i]);
                }
            }

            min.Sort();
            plus.Sort();
            plus.Reverse();

            int answer = 0;
            int max = int.MinValue;
            while(min.Count != 0)
            {
                int temp = Math.Abs(min[0]);
                max = Math.Max(max, temp);
                answer += temp * 2;

                for(int i=0; i<m; i++)
                {
                    if(min.Count != 0)
                    {
                        min.RemoveAt(0);
                    }
                }
            }

            while (plus.Count != 0)
            {
                int temp = plus[0];
                max = Math.Max(max, temp);
                answer += temp * 2;

                for (int i = 0; i < m; i++)
                {
                    if (plus.Count != 0)
                    {
                        plus.RemoveAt(0);
                    }
                }
            }

            answer -= max;
            Console.WriteLine(answer);
        }
    }
}
