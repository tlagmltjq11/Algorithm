using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _9184
    {
        static int[,,] dp = new int[55,55,55];

        static int w(int a, int b, int c)
        { 
            if(a <= 0 || b <= 0 || c <= 0)
            {
                return 1;
            }

            //이미 계산되어있다면 곧바로 반환
            if(dp[a,b,c] != 0)
            {
                return dp[a, b, c];
            }

            //계산되어있지 않기 때문에, 계산 후 저장해 Memoization 구현
            if (a > 20 || b > 20 || c > 20)
            {
                return dp[20,20,20] = w(20, 20, 20);
            }

            if(a < b && b < c)
            {
                return dp[a,b,c] = w(a, b, c - 1) + w(a, b - 1, c - 1) - w(a, b - 1, c);
            }
            else
            {
                return dp[a, b, c] =  w(a - 1, b, c) + w(a - 1, b - 1, c) + w(a - 1, b, c - 1) - w(a - 1, b - 1, c - 1);
            }
        }

        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            string[] read;
            int[] nums = new int[3];

            while(true)
            {
                read = Console.ReadLine().Split(" ");
                nums = Array.ConvertAll<string, int>(read, s => int.Parse(s));

                bool check = false;
                for(int i=0; i<3; i++)
                {
                    if(nums[i] != -1)
                    {
                        check = true;
                        break;
                    }
                }

                if(!check)
                {
                    break;
                }
                else
                {
                    int result = w(nums[0], nums[1], nums[2]);
                    sb.Append(string.Format("w({0}, {1}, {2})", nums[0], nums[1], nums[2]) + " = " + result);
                    sb.AppendLine();
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
