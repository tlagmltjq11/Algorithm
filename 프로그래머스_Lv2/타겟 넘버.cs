using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 타겟_넘버
    {
        static int[] nums;
        static int cnt, size;

        static void DFS(int depth, int curNum, int target)
        {
            if(depth == size)
            {
                if(curNum == target)
                {
                    cnt++;
                }

                return;
            }

            DFS(depth + 1, curNum + nums[depth], target);
            DFS(depth + 1, curNum - nums[depth], target);
        }

        static int solution(int[] numbers, int target)
        {
            int answer = 0;
            size = numbers.Length;
            nums = numbers;

            DFS(0, 0, target);
            answer = cnt;

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(new int[] { 1, 1, 1, 1, 1 }, 3));
        }
    }
}
