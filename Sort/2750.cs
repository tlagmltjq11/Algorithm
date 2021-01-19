using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2750
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] nums = new int[N];
            int temp;

            for(int i=0; i<N; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0; i<N; i++)
            {
                for(int j=0; j<N-i-1; j++) //한 사이클마다 제일큰 수가 맨오른쪽에 배치되기 때문에 -i만큼 덜 반복할 수 있다.
                {
                    if(nums[j] > nums[j + 1])
                    {
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }

            for(int i=0; i<N; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
