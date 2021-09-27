using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1764
    {
        static void Main()
        {
            string[] nm = Console.ReadLine().Split(" ");
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            HashSet<string> set = new HashSet<string>();
            for(int i=0; i<n; i++)
            {
                string temp = Console.ReadLine();
                set.Add(temp);
            }

            List<string> answer = new List<string>();
            for(int i=0; i<m; i++)
            {
                string temp = Console.ReadLine();

                if(set.Contains(temp))
                {
                    answer.Add(temp);
                }
            }

            Console.WriteLine(answer.Count);
            answer.Sort();
            for(int i=0; i<answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }
    }
}
