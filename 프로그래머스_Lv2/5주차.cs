using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _5주차
    {
        static int solution(string word)
        {
            string str = "AEIOU";
            int[] nums = new int[] { 781, 156, 31, 6, 1 };
            int ret = 0;
            for (int i = 0; i < word.Length; i++)
                ret += str.IndexOf(word[i]) * nums[i] + 1;
            return ret;
        }

        static void Main()
        {
            Console.WriteLine(solution("AAAAE"));
        }
    }
}
