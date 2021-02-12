using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class _9461
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());
            long[] nums = new long[101];

            nums[1] = nums[2] = nums[3] = 1;
            nums[4] = nums[5] = 2;

            for(int i=6; i<101; i++)
            {
                //파도반 수열의 규칙은 N번째 수 = N-1번째 수 + N-5번째 수
                nums[i] = nums[i - 1] + nums[i - 5];
            }

            for(int i=0; i<N; i++)
            {
                int read = int.Parse(Console.ReadLine());
                sb.AppendLine(nums[read].ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
    */
}
