using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _6064
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                int m = int.Parse(input[0]);
                int n = int.Parse(input[1]);
                int x = int.Parse(input[2]);
                int y = int.Parse(input[3]);

                int max = m * n;
                int index = 0;

                if (y == n)
                {
                    y = 0;
                }

                int answer = 0;
                while (true)
                {
                    if ((m * index + x) % n == y)
                    {
                        answer = m * index + x;
                        break;
                    }

                    if (m * index + x > max)
                    {
                        answer = -1;
                        break;
                    }
                    index++;
                }

                Console.WriteLine(answer);
            }
        }
    }
}
