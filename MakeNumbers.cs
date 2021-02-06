using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class MakeNumbers
    {
        static int[] solution(int[] numbers)
        {
            int[] answer = new int[] { };
            List<int> list = new List<int>();

            for(int i=0; i<numbers.Length; i++)
            {
                for(int j=i+1; j<numbers.Length; j++)
                {
                    if(!list.Contains(numbers[i] + numbers[j]))
                    {
                        list.Add(numbers[i] + numbers[j]);
                    }
                }
            }

            answer = list.ToArray();
            Array.Sort(answer);

            return answer;
        }

        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int[] arr = new int[4] { 5,0,2,7 };

            int[] result = solution(arr);

            for(int i=0; i<result.Length; i++)
            {
                sb.Append(result[i] + " ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
    */
}
