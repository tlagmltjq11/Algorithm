using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1436
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int num = 6659;

            if (N < 7)
            {
                Console.WriteLine((N - 1) * 1000 + 666);
                return;
            }
            else
            {
                int cnt = 0;
                string temp;

                while(true)
                {
                    ++num;

                    temp = num.ToString();

                    if(temp.Contains("666"))
                    {
                        cnt++;
                    }

                    if(cnt + 6 == N)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(num);
        }
    }
}
