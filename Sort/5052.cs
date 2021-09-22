using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _5052
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder answer = new StringBuilder();

            for(int i=0; i<t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string[] str = new string[n];

                for(int j=0; j<n; j++)
                {
                    string temp = Console.ReadLine();
                    str[j] = temp;
                }

                Array.Sort(str);

                bool check = false;
                for(int j=0; j<n-1; j++)
                {
                    if(str[j+1].StartsWith(str[j]))
                    {
                        answer.AppendLine("NO");
                        check = true;
                        break;
                    }
                }

                if(!check)
                {
                    answer.AppendLine("YES");
                }
            }

            Console.WriteLine(answer.ToString());
        }
    }
}
