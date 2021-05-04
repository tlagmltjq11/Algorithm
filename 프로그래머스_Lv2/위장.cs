using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 위장
    {
        static int solution(string[,] clothes)
        {
            int answer = 1;

            Dictionary<string, int> dict = new Dictionary<string, int>();

            for(int i=0; i<clothes.GetLength(0); i++)
            {
                if(dict.ContainsKey(clothes[i, 1]))
                {
                    dict[clothes[i, 1]]++;
                }
                else
                {
                    dict.Add(clothes[i, 1], 1);
                }
            }

            foreach(var cloth in dict)
            {
                answer *= (cloth.Value+1);
            }

            answer--;

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(new string[,] { { "yellow_hat", "headgear" }, { "blue_sunglasses", "eyewear" }, { "green_turban", "headgear" } }));
        }
    }
}
