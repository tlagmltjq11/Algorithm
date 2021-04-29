using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 주식가격
    {
        static int[] solution(int[] prices)
        {
            int[] answer = new int[prices.Length];

            for(int i=0; i<prices.Length; i++)
            {
                int cnt = 0;

                for(int j=i+1; j<prices.Length; j++)
                {
                    cnt++;
                    if(prices[i] > prices[j])
                    {
                        break;
                    }
                }

                answer[i] = cnt;
            }


            return answer;
        }

        static void Main()
        {
            int[] ans = solution(new int[] { 1, 2, 3, 2, 3 });

            for(int i=0; i<ans.Length; i++)
            {
                Console.Write(ans[i]);
            }
        }
    }
}
