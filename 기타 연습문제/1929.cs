using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1929
    {
        //알고보니 c#의 console.writeline이 너무 느려서 계속 시간초과가 떴음..
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(" ");
            int M = int.Parse(data[0]);
            int N = int.Parse(data[1]);

            bool[] num = new bool[N+1];

            //에라토스테네스의 체
            //처음부터 2, 3 이런 순서로 시작되므로 굳이 소수인지 판별안해도됨.
            for (int i=2; i<=N; i++)
            {
                if(num[i])
                {
                    continue;
                }

                for(int j=i*2; j<=N; j+=i)
                {
                    num[j] = true;
                }
            }

            for(int i=M; i<=N; i++)
            {
                if(!num[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
