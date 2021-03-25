using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1654
    {
        static void Main()
        {
            string[] read = Console.ReadLine().Split(" ");

            int k = int.Parse(read[0]);
            int n = int.Parse(read[1]);
            int[] lines = new int[k];
            long max = 0;
            long result = 0;

            for(int i=0; i<k; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                lines[i] = temp;

                max = Math.Max(max, temp);
            }

            long left = 1;
            long right = max;
            
            while(left <= right)
            {
                long mid = (left + right) / 2;
                long cnt = 0;
                for(int i=0; i<k; i++)
                {
                    cnt += (lines[i] / mid);
                }

                if (cnt >= n)
                {
                    result = Math.Max(result, mid);
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            Console.WriteLine(result);
        }
    }
}
