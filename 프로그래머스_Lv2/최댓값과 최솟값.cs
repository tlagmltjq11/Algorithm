using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 최댓값과_최솟값
    {
        static string solution(string s)
        {
            string answer = "";

            int[] arr = Array.ConvertAll<string, int>(s.Split(" "), s => int.Parse(s));

            Array.Sort(arr);

            answer += arr[0] + " " + arr[arr.Length - 1];

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution("1 2 3 4"));
        }
    }
}
