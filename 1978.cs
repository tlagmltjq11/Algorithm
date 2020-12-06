using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1978
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split(" ");
            int cnt = 0;

            //에라토스테네스의 체 로도 풀 수 있는 문제.
            for(int i=0; i<N; i++)
            {
                int num = Convert.ToInt32(nums[i]);
                bool flag = false;

                if(num == 1)
                {
                    continue;
                }

                for(int j=2; j<num; j++)
                {
                    if(num % j == 0)
                    {
                        flag = true;
                        break;
                    }
                }

                if(!flag)
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
            
        }
    }
}
