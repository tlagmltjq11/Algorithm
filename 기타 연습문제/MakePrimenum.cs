using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class MakePrimenum
    {
        static int solution(int[] nums)
        {
            int answer = 0;
            List<int> list = new List<int>();

            for(int i=0; i<nums.Length; i++)
            {
                for(int j=i+1; j<nums.Length; j++)
                {
                    for(int k=j+1; k<nums.Length; k++)
                    {
                        list.Add(nums[i] + nums[j] + nums[k]);
                    }
                }
            }

            for(int i=0; i<list.Count; i++)
            {
                bool check = false;

                //list[i] / 2 까지만 검사해도된다. 그 뒤는 이미 검사된 부분임.
                for (int j=2; j<list[i] / 2; j++)
                {
                    if(list[i] % j == 0)
                    {
                        check = true;
                        break;
                    }
                }

                if(!check)
                {
                    answer++;
                }
            }

            return answer;
        }

        static void Main()
        {
            int[] arr = new int[5] { 1, 2, 7, 6, 4 };
            Console.WriteLine(solution(arr));
        }
    }
    */
}
