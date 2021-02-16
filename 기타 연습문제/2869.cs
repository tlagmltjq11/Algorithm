using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice.NewFolder
{
    class _2869
    {
        
        static void Main(string[] args)
        {
            /*
            //첫번째코드는 시간초과!
            
            string[] abv = Console.ReadLine().Split(" ");

            int A = int.Parse(abv[0]);
            int B = int.Parse(abv[1]);
            int V = int.Parse(abv[2]);

            int day = 0;
            int progress = 0;

            while(true)
            {
                day++;
                progress += A;

                if(progress >= V)
                {
                    Console.WriteLine(day);
                    break;
                }

                progress -= B;
            }
            */
            

            //두번째코드 통과
            //설명 : 정상에 도달하면 미끄러지지않으므로 우리가 총 가야하는 거리는
            //V - B가 된다. 그리고 하루마다 A-B거리를 이동하는데 만약 나누어 떨어지면
            //딱 그 수만큼 날이 지나면 되는 것이고, 나누어 떨어지지않으면 하루만 더가면 된다.
            string[] abv = Console.ReadLine().Split(" ");

            int A = int.Parse(abv[0]);
            int B = int.Parse(abv[1]);
            int V = int.Parse(abv[2]);

            int distance = V - B;
            
            if((distance % (A-B)) == 0)
            {
                Console.WriteLine(distance / (A - B));
            }
            else
            {
                Console.WriteLine((distance / (A - B)) + 1);
            }
        }
        
    }

}
