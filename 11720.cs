using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _11720
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string numbers = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += int.Parse(numbers[i].ToString());
            }

            Console.WriteLine(sum);
        }
    }
}
