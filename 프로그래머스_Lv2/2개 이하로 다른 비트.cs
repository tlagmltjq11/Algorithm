using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2개_이하로_다른_비트
    {
        static long[] solution(long[] numbers)
        {
            List<long> list = new List<long>();
            long[] answer;

            for (int i = 0; i < numbers.Length; i++)
            {
                //짝수일 경우 가장 오른쪽 비트가 0이므로 1만 더해주면
                //총 1비트가 다른 가장 작은 수를 바로 구할 수 있다.
                if (numbers[i] % 2 == 0)
                {
                    list.Add(numbers[i] + 1);
                }
                //홀수일 경우 가장 오른쪽 비트는 1이며
                //가장 오른쪽 부터 연속된 1의 비트의 수가 중요하다.
                //1을 더했을때 '올림'을 생각해야 하기 때문.

                //규칙을 찾아보면 오른쪽부터 연속된 1중 마지막 1에
                //1을 더해주면 조건을 만족하는 값을 찾을 수 있음.
                else
                {
                    long bit = 1;
                    //0비트를 찾을때까지 진행 -> 마지막 1비트를 찾는 구간이됨.
                    //&비트연산자는 둘다 1이어야 1값을 내기 때문에 0이 둘중 하나라도
                    //존재하면 0이 나온다. 고로 2씩 증가하는 bit는 비트의 한자릿수씩
                    //증가하게 되는데 만약 위의 비트가 0일 경우가 생기면 전체 값이 0이되므로
                    //0비트의 위치를 찾을 수 있게 된다. (위 비트가 1이면 전체 값이 0이 될 수 없음)
                    while (true)
                    {
                        if ((numbers[i] & bit) == 0) break;
                        bit *= 2;
                    }
                    bit = bit / 2; //0비트 이전인 마지막 1비트 위치로 이동

                    list.Add(numbers[i] + bit); //해당 값을 더해주면 값을 찾는다.
                }
            }

            answer = list.ToArray();
            return answer;
        }

        static void Main()
        {
            long[] result = solution(new long[] { 2, 7 });

            for(int i=0; i<result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
