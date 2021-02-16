using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1011
    {
        //https://www.youtube.com/watch?v=uJJuYxtvPo4&t=256s 보면서 공부함.
        static void Main(string[] args)
        {
            int testCaes = int.Parse(Console.ReadLine());

            for(int i=0; i<testCaes; i++)
            {
                string[] data = Console.ReadLine().Split(" ");

                int x = int.Parse(data[0]);
                int y = int.Parse(data[1]);

                //가야할 거리
                int dist = y - x;
                //dist에따라 낼 수 있는 최고속도
                int k = 0;

                while(true)
                {
                    k++;
                    
                    if(dist - (k * k) <= 0)
                    {
                        break;
                    }
                }

                //만약  k^2과 거리가 딱맞아떨어진다면 1부터 k까지 속도를 올렸다가 k부터 1씩 속도를 내리면 문제의 조건에
                //맞게 도착지에 도착이 가능하다는 것.
                //고로 k까지 속력을 올리는데 k단계 속도를 1까지 내려 도착지에 가는데 k-1단계 
                // -> 2k - 1단계에 도착!
                if(dist - (k * k) == 0)
                {
                    Console.WriteLine(2 * k - 1);
                }
                //만약 맞지않는다면
                else
                {
                    //k를 1내려준다 이유는 위에 while문에서 어림잡아 k를 구한것인데 
                    //k까지 속력을 올렸다가는 조건에 부합하게 도착을 못한다는 의미가됨.
                    //고로 속도를 1 빼줌.
                    k = k - 1;

                    //남는거리가 k이하면 해당 남는거리와 동일한 속도로 1번만 더 진행해주면됨
                    //고로 + 1
                    if(dist - (k * k) <= k)
                    {
                        Console.WriteLine(2 * k);
                    }
                    //k보다 크다면 2번에 나눠서 진행해줘야하기 때문에 +2
                    else
                    {
                        Console.WriteLine(2 * k + 1);
                    }
                }
            }
        }
    }
}
