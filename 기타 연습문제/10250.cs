using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _10250
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                string[] data = Console.ReadLine().Split(" ");

                int H = int.Parse(data[0]);
                int V = int.Parse(data[1]);
                int N = int.Parse(data[2]);

                int floor;
                int room;

                if ((N % H) == 0)
                {
                    floor = H;
                }
                else
                {
                    floor = N % H;
                }

                room = N / H + 1;

                if ((N % H) == 0)
                {
                    room--;
                }

                Console.WriteLine(floor * 100 + room);
            }
        }
    }
}
