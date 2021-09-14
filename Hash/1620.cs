using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1620
    {
        static void Main()
        {
            string[] nm = Console.ReadLine().Split(" ");
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            Dictionary<string, string> dict = new Dictionary<string, string>();

            for(int i=1; i<=n; i++)
            {
                string pocketMon = Console.ReadLine();

                dict.Add(pocketMon, i.ToString());
                dict.Add(i.ToString(), pocketMon);
            }

            StringBuilder sb = new StringBuilder();
            for(int i=0; i<m; i++)
            {
                sb.AppendLine(dict[Console.ReadLine()]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
