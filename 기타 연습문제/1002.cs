using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1002
    {
        static void Main()
        {
            int testCase = int.Parse(Console.ReadLine());
            int x1, y1, r1, x2, y2, r2;

            for(int i=0; i<testCase; i++)
            {
                string[] data = Console.ReadLine().Split(" ");

                x1 = int.Parse(data[0]);
                y1 = int.Parse(data[1]);
                r1 = int.Parse(data[2]);

                x2 = int.Parse(data[3]);
                y2 = int.Parse(data[4]);
                r2 = int.Parse(data[5]);

                int distance = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
                int radSum = (r1 + r2) * (r1 + r2);
                int radDif = (r2 - r1) * (r2 - r1);

                //좌표가 같은경우
                if (distance == 0)
                {
                    //반지름까지 같은경우
                    if (r1 == r2)
                    {
                        Console.WriteLine(-1);
                    }
                    else
                    {
                        Console.WriteLine(0);
                    }
                }
                //두점에서 원이 만나는 경우
                else if (radDif < distance && distance < radSum)
                {
                    Console.WriteLine(2);
                }
                //외접 혹은 내접하는 경우
                else if (radSum == distance || radDif == distance)
                {
                    Console.WriteLine(1);
                }
                //아예 멀리 떨어져 만나지못하는 경우
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
