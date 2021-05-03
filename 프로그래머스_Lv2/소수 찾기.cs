using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 소수_찾기
    {
        static List<int> nums = new List<int>();
        static HashSet<int> set = new HashSet<int>();
        static bool[] selected;

        static bool isPrime(int n)
        {
            for(int i=2; i<= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Search(int depth, string n = "")
        {
            if(depth == nums.Count)
            {
                return;
            }

            for(int i=0; i<nums.Count; i++)
            {
                if(selected[i] == false)
                {
                    n += nums[i];
                    set.Add(int.Parse(n));
                    selected[i] = true;
                    Search(depth + 1, n);
                    selected[i] = false;
                }
                else
                {
                    continue;
                }

                n = n.Substring(0, n.Length - 1);
            }
        }

        static int solution(string numbers)
        {
            int answer = 0;

            //숫자 종이 조각 리스트
            for(int i=0; i<numbers.Length; i++)
            {
                nums.Add(numbers[i] - '0');
            }
            selected = new bool[numbers.Length];

            Search(0);

            foreach(int v in set)
            {
                if(v == 0 || v == 1)
                {
                    continue;
                }

                if(isPrime(v))
                {
                    answer++;
                }
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution("17"));
        }
    }
}
