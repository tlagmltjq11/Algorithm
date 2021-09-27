using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _5525
    {
        static void Main()
        {
            int answer = 0;
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            string s = Console.ReadLine();

            StringBuilder sb = new StringBuilder("I");
            for (int i=0; i<n; i++)
            {
                sb.Append("OI");
            }

            string compare = sb.ToString();
            int size = compare.Length;
            for (int i=0; i<=m-size; i++)
            {
                if(s.Substring(i, size).Equals(compare))
                {
                    answer++;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
