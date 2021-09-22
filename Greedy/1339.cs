using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice.NewFolder
{
    class _1339
    {
        static void Main()
        {

            //testcase 및 문자열 입력
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            int[] alpha = new int[26];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                int temp = (int)Math.Pow(10, arr[i].Length - 1);
                for (int j = 0; j < arr[i].Length; j++)
                {
                    alpha[(int)arr[i][j] - 65] += temp;
                    temp /= 10;
                }
            }

            Array.Sort(alpha);
            int index = 9;
            int sum = 0;
            for (int i = alpha.Length - 1; i >= 0; i--)
            {
                if (alpha[i] == 0)
                {
                    break;
                }
                sum += alpha[i] * index;
                index--;
            }

            Console.WriteLine(sum);
        }
    }
}
