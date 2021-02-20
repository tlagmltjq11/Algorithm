using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _11047
    {
        static void Main()
        {
            int n, k, cnt = 0;
            string[] read = Console.ReadLine().Split(" ");

            n = int.Parse(read[0]);
            k = int.Parse(read[1]);

            int[] nums = new int[n];

            for(int i=0; i<n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            for(int i=n-1; i>=0; i--)
            {
                if(k / nums[i] > 0)
                {
                    cnt += k / nums[i];
                    k = k % nums[i];
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
