using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _9372
    {
        static void Main()
        {
            int test = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < test; i++)
            {
                string[] read = Console.ReadLine().Split(" ");
                int n = int.Parse(read[0]);
                int m = int.Parse(read[1]);

                sb.AppendLine((n - 1).ToString());

                for(int j=0; j<m; j++)
                {
                    read = Console.ReadLine().Split(" ");
                }
            }

            Console.WriteLine(sb.ToString());
        }

    }
}
