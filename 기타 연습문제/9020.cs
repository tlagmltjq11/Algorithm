using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _9020
    {
        static void Main(string[] args)
        {
            //에라토스테네스의 체 를 이용해서 소수를 먼저 구함.
            bool[] num = new bool[10001];

            for(int i = 2; i <= 10000; i++)
            {
                num[i] = true;
            }

            for (int i = 2; i <= 10000; i++)
            {
                if (!num[i])
                {
                    continue;
                }

                for (int j = i * 2; j <= 10000; j += i)
                {
                    num[j] = false;
                }
            }


            int testCase = int.Parse(Console.ReadLine());


            for(int i=0; i<testCase; i++)
            {
                int data = int.Parse(Console.ReadLine());
                int p1, p2;

                p1 = p2 = data / 2;
                while(true)
                {
                    //p1, p2의 차가 가장 적은 파티션으로 출력해야하기 때문에
                    //절반값부터 시작
                    if ((p1 + p2 == data) && num[p1] && num[p2])
                    {
                        Console.WriteLine(p1 + " " + p2);
                        break;
                    }

                    //하나는 감소 하나는 증가하는식으로 차가 가장 적은 파티션을 구함.
                    p1--;
                    p2++;
                }
            }
        }
    }
}
