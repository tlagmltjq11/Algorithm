using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 큰_수_만들기
    {
        static string solution(string number, int k)
        {
            string answer = "";

            int size = number.Length - k;
            int len = number.Length;
            int index = -1;
            int i, max, temp;

            while (size > 0)
            {
                max = -1;
                i = index + 1;

                for(; i<= len - size; i++)
                {

                    temp = number[i] - '0';

                    if (temp == 9)
                    {
                        max = temp;
                        index = i;
                        break;
                    }

                    if (max < temp)
                    {
                        max = temp;
                        index = i;
                    }
                }

                size--;
                answer += max;
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution("1231234", 3));
        }
    }
}
