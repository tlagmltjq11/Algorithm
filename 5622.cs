using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _5622
    {
        static int CapitalToNum(char c)
        {
            if (c >= 'A' && c <= 'C')
                return 2;
            else if (c >= 'D' && c <= 'F')
                return 3;
            else if (c >= 'G' && c <= 'I')
                return 4;
            else if (c >= 'J' && c <= 'L')
                return 5;
            else if (c >= 'M' && c <= 'O')
                return 6;
            else if (c >= 'P' && c <= 'S')
                return 7;
            else if (c >= 'T' && c <= 'V')
                return 8;
            else if (c >= 'W' && c <= 'Z')
                return 9;
            else
                return 0;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] words = input.ToCharArray();

            int sum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                int a = CapitalToNum(words[i]);
                sum += (a + 1);
            }

            Console.WriteLine(sum);
        }
    }
}
