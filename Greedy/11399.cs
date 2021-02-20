using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _11399
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), s => int.Parse(s));

            Array.Sort(nums);

            int result = nums[0];
            int dp = nums[0];

            for(int i=1; i<n; i++)
            {
                dp = nums[i] + dp;
                result += dp;
            }

            Console.WriteLine(result);
        }
    }
}
