using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 하노이의_탑
    {
        static List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();

        static void Move(int from, int to)
        {
            list.Add(new KeyValuePair<int, int>(from, to));
        }

        static void Hanoi(int n, int from, int to, int via)
        {
            //원판이 1개인 경우 바로 이동
            if(n == 1)
            {
                Move(from, to);
            }
            else
            {
                //맨 아래 원판을 제외한 위 원판들을 via로 이동
                Hanoi(n - 1, from, via, to);
                //맨 아래 원판을 목적지로 이동
                Move(from, to);
                //위에서 옮겨뒀던 위 원판들을 최종 목적지로 이동
                Hanoi(n - 1, via, to, from);
            }
        }

        static int[,] solution(int n)
        {
            int[,] answer;

            Hanoi(n, 1, 3, 2);

            int size = list.Count;
            answer = new int[size, 2];
            for(int i=0; i< size; i++)
            {
                answer[i, 0] = list[i].Key;
                answer[i, 1] = list[i].Value;
            }

            return answer;
        }

        static void Main()
        {
            int[,] result = solution(2);

            for(int i=0; i<result.GetLength(0); i++)
            {
                for(int j=0; j<result.GetLength(1); j++)
                {
                    Console.WriteLine(result[i, j]);
                }
            }
        }
    }
}
