using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _12015
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] read = Console.ReadLine().Split(" ");
            int[] nums = new int[n];

            for(int i=0; i<n; i++)
            {
                nums[i] = int.Parse(read[i]);
            }

            List<int> list = new List<int>();
            list.Add(0); //수열의 최솟값이 1이므로 비교를 위해 0을 미리 넣는다.

            int value, left, right, mid;
            for (int i = 0; i < n; i++)
            {
                value = nums[i];

                // 수열의 값이 리스트의 맨 끝 값보다 크면 리스트에 넣음	
                if (value > list[list.Count - 1])
                {
                    list.Add(value);
                }
                // 〃 작으면 리스트 안에서 이분탐색을 하여 알맞은 자리에 값을 대치
                else
                {
                    left = 0;
                    right = list.Count - 1;

                    while (left < right)
                    {
                        mid = (left + right) / 2;

                        if (value <= list[mid])
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    list[right] = value;
                }
            }

            Console.WriteLine(list.Count - 1);
        }
    }
}
