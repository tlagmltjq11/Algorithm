using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 이진_변환_반복하기
    {
        static int[] solution(string s)
        {
            int[] answer = new int[2];
            int cntZero = 0;
            int cntLoop = 0;

            while(!s.Equals("1"))
            {
                cntLoop++; //반복횟수 + 1

                int length = s.Length; //이전 길이
                s = s.Replace("0", ""); //0을 제거
                cntZero += (length - s.Length); //제거된 0의 갯수 더하기

                s = Convert.ToString(s.Length, 2); //s의 길이를 2진수로 변환 후 s에 대입
            }

            answer[0] = cntLoop;
            answer[1] = cntZero;

            return answer;
        }

        static void Main()
        {
            int[] result = solution("110010101001");

            for(int i=0; i<result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
