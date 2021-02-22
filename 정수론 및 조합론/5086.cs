using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _5086
    {
        static StringBuilder sb = new StringBuilder();

        static void Check(int n1, int n2)
        {
            if(n2 % n1 == 0)
            {
                sb.AppendLine("factor");
            }
            else if(n1 %  n2 == 0)
            {
                sb.AppendLine("multiple");
            }
            else
            {
                sb.AppendLine("neither");
            }
        }

        static void Main()
        {
            int n1, n2;

            while(true)
            {
                string[] read = Console.ReadLine().Split(" ");
                n1 = int.Parse(read[0]);
                n2 = int.Parse(read[1]);

                if(n1 != 0 && n2 != 0)
                {
                    Check(n1, n2);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
