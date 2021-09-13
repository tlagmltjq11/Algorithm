using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1074
    {
        static int r, c;
        static int ans = 0;

        static void Recur(int size, int start_X, int start_Y)
        {
            if(start_X == r && start_Y == c)
            {
                Console.WriteLine(ans);
                return;
            }

            //해당 구역에 r,c 가 존재하는지 체크하고 
            //존재 할 경우에만 분할하여 재귀호출한다.
            if(start_X <= r && r < start_X + size && start_Y <= c && c < start_Y + size)
            {
                int temp = size / 2;
                Recur(temp, start_X, start_Y); //2사분면
                Recur(temp, start_X, start_Y + temp); //1사분면
                Recur(temp, start_X + temp, start_Y); //3사분면
                Recur(temp, start_X + temp, start_Y + temp); //4사분면
            }
            //존재하지 않을 경우
            else
            {
                ans += (int)Math.Pow(size, 2);
            }
        }

        static void Main()
        {
            string[] nrc = Console.ReadLine().Split(" ");
            int n = (int)Math.Pow(2, int.Parse(nrc[0]));
            r = int.Parse(nrc[1]);
            c = int.Parse(nrc[2]);

            Recur(n, 0, 0);
        }
    }
}
