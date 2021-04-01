using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2805
    {
        static void Main()
        {
            int n, m, temp;
            string[] read = Console.ReadLine().Split(" ");
            n = int.Parse(read[0]);
            m = int.Parse(read[1]);

            int[] trees = new int[n];
            read = Console.ReadLine().Split(" ");

            long max = 0;
            for (int i=0; i<n; i++)
            {
                temp = int.Parse(read[i]);
                trees[i] = temp;

                max = Math.Max(max, temp);
            }

            long left = 0;
            long right = max;
            long mid, sum;

            while(left <= right)
            {
                mid = (left + right) / 2;
                sum = 0;

                for(int i=0; i<n; i++)
                {
                    if(trees[i] > mid)
                    {
                        sum += (trees[i] - mid);
                    }
                }

                if (sum >= m)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            Console.WriteLine(right);
        }
    }
}
