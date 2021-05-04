using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 카펫
    {
        static int[] solution(int brown, int yellow)
        {
            int[] answer = new int[2];

            int sum = brown + yellow; //전체 정사각형의 넓이

            for(int i=3; ; i++)
            {
                int temp = 0;

                if(sum % i == 0)
                {
                    temp = sum / i;

                    if((i-2) * (temp - 2) == yellow)
                    {
                        answer[0] = temp;
                        answer[1] = i;
                        break;
                    }
                }
            }

            return answer;
        }

        static void Main()
        {

        }
    }
}
