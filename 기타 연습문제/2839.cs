using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    //다음번에 다시 풀때에는 봉지 1개씩 추가해나가는 방식으로 풀어야함.
    //그게 좀 더 효율적임.
    class _2839
    {
        static void Main(string[] args)
        {
            int sugar = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            int sug5 = 0;

            while((5 * sug5) <= sugar)
            {
                if ((sugar - (5 * sug5) == 0))
                {
                    result.Add(sug5);
                    break;
                }
                else
                { 
                    if (((sugar - (5 * sug5)) % 3) == 0)
                    {
                        int sug3 = (sugar - (5 * sug5)) / 3;

                        result.Add(sug5 + sug3);
                    }
                }

                sug5++;
            }

            if(result.Count == 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                result.Sort();
                Console.WriteLine(result[0]);
            }
        }
    }
}
