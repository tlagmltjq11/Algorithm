using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1065
    {
        static int han(int n)
        {
            int cnt = 0;

            if(n <= 99)
            {
                return n;
            }
            else
            {
                int a, b, c;
                for(int i=100; i<=n; i++)
                {
                    a = i / 100;
                    b = (i / 10) % 10;
                    c = i % 10;

                    if((c-b) == (b-a))
                    {
                        cnt++;
                    }
                }

                cnt += 99;
            }

            return cnt;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(han(n));
        }
    }
}
