using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _13305
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long[] distance = Array.ConvertAll<string, long>(Console.ReadLine().Split(" "), s => long.Parse(s));
            long[] price = Array.ConvertAll<string, long>(Console.ReadLine().Split(" "), s => long.Parse(s));

            long result = 0;
            long greedy = 1000000000;

            for (int i = 0; i < price.Length-1; i++)
            {
                if (greedy > price[i])
                {
                    greedy = price[i];
                }

                result += greedy * distance[i];
            }

            Console.WriteLine(result);
        }
    }
}