using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 가장_큰_수
    {

        static string solution(int[] numbers)
        {
            StringBuilder sb = new StringBuilder();

            List<string> list = new List<string>();

            for(int i=0; i<numbers.Length; i++)
            {
                list.Add(numbers[i].ToString());
            }

            list.Sort((a, b) => (a + b).CompareTo(b + a));

            //제일 큰 수가 0이라면 모든 수가 0일것임.
            if(list[list.Count-1] == "0")
            {
                return "0";
            }


            for(int i=list.Count-1; i>=0; i--)
            {
                sb.Append(list[i]);
            }

            return sb.ToString();
        }

        static void Main()
        {
            Console.WriteLine(solution(new int[] { 3, 30, 34, 5, 9 }));
        }
    }
}
