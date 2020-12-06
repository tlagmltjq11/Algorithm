using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2581
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int min = 0;
            int sum = 0;

            for (int i = M; i <= N; i++)
            {
                bool flag = false;

                if (i == 1)
                {
                    continue;
                }

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    if(sum == 0)
                    {
                        min = i;
                    }

                    sum += i;
                }
            }

            if(sum == 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(sum);
                Console.WriteLine(min);
            }
        }
    }
}
