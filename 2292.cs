using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2292
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            int temp = 1;

            while (true)
            {
                //6의 배수씩 더해가면서 그 범위내에 있는 수인지 판별
                temp += (cnt * 6);

                if (temp >= n)
                {
                    Console.WriteLine(cnt + 1);
                    break;
                }

                cnt++;
            }
        }
    }
}