using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _10870
    {
        static int Fibo(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            else if(n <= 2)
            {
                return 1;
            }
            else
            {
                return Fibo(n - 1) + Fibo(n - 2);
            }
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibo(n));
        }
    }
}
