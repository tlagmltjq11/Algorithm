using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2231
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int temp = N;
            int digit = 0;
            bool check = false;

            while(temp > 0)
            {
                temp /= 10;
                digit++;
            }

            //생성자 + 각 자릿수인데 각 자릿수마다 최대값은 9임
            //고로 자릿수 * 9 만큼만 반복해보면 시간을 단축시킬 수 있다.
            for (int i=N - (digit * 9); i<N; i++)
            {
                int sum = i;
                int _digit = i;

                while(_digit > 0)
                {
                    sum += _digit % 10;
                    _digit /= 10;
                }

                if(sum == N)
                {
                    Console.WriteLine(i);
                    check = true;
                    break;
                }
            }

            if (!check)
            {
                Console.WriteLine(0);
            }
        }
    }
}
