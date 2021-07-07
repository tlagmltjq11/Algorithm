using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 쿼드압축_후_개수_세기
    {
        static int[] ans = new int[2];
        static int[,] matrix;

        static void Divide(int start_X, int start_Y, int size)
        {
            bool check = false;

            if(size == 1)
            {
                ans[matrix[start_X, start_Y]]++;
                return;
            }

            for(int i=start_X; i<start_X + size; i++)
            {
                for(int j=start_Y; j<start_Y + size; j++)
                {
                    if(matrix[i, j] != matrix[start_X, start_Y])
                    {
                        check = true;
                        break;
                    }
                }
            }

            //start부터 end까지 모든 수가 동일한 경우
            if(!check)
            {
                ans[matrix[start_X, start_Y]]++;
                return;
            }
            //동일하지 않은 경우
            else
            {
                size /= 2;
                Divide(start_X, start_Y, size);
                Divide(start_X, start_Y + size, size);
                Divide(start_X + size, start_Y, size);
                Divide(start_X + size, start_Y + size, size);
            }

            return;
        }

        static int[] solution(int[,] arr)
        {
            int[] answer = new int[2];
            int size = arr.GetLength(0);

            matrix = arr;
            Divide(0, 0, size);

            answer[0] = ans[0];
            answer[1] = ans[1];

            return answer;
        }

        static void Main()
        {
            int[] result = solution(new int[,] { { 1, 1, 0, 0 }, { 1, 0, 0, 0 }, { 1, 0, 0, 1 }, { 1, 1, 1, 1 } });

            for(int i=0; i<result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
