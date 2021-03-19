using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1920
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int[] nums = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), s => int.Parse(s));
            Array.Sort(nums);

            int m = int.Parse(Console.ReadLine());
            int[] test = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), s => int.Parse(s));

            for(int i=0; i<test.Length; i++)
            {
                int left = 0;
                int right = nums.Length - 1;
                int find = test[i];
                bool check = false;

                while(left <= right)
                {
                    int index = (left + right) / 2;
                    int mid = nums[index];
                    
                    if(mid == find)
                    {
                        check = true;
                        sb.AppendLine("1");
                        break;
                    }
                    else if(mid > find)
                    {
                        right = index - 1;
                    }
                    else
                    {
                        left = index + 1;
                    }
                }

                if(!check)
                {
                    sb.AppendLine("0");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
