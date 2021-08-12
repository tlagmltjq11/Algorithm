using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class N_Queen
    {
        static bool[,] matrix;
        static int cnt = 0;
        static int size;

        static bool Check(int x, int y)
        {
            for(int i=1; i<=x; i++)
            {
                //같은 수직선 상에 다른 퀸이 존재할 경우
                if(matrix[x-i, y] == true)
                {
                    return false;
                }

                //체스판 범위 내에서만 체크하도록 함.
                if(y-i >= 0)
                {
                    //왼쪽 위 대각선 상에 다른 퀸이 존재할 경우
                    if (matrix[x-i, y-i] == true)
                    {
                        return false;
                    }
                }

                //체스판 범위 내에서만 체크하도록 함.
                if (y+i < size)
                {
                    //오른쪽 위 대각선 상에 다른 퀸이 존재할 경우
                    if (matrix[x - i, y + i] == true)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static void BackTracking(int depth)
        {
            if(depth == size)
            {
                cnt++;
                return;
            }

            for(int i=0; i<size; i++)
            {
                if(Check(depth, i))
                {
                    matrix[depth, i] = true;
                    BackTracking(depth + 1);
                    matrix[depth, i] = false;
                }
            }
        }

        static int solution(int n)
        {
            int answer = 0;
            matrix = new bool[n, n];
            size = n;

            BackTracking(0);

            answer = cnt;
            return answer;
        }

        static void Main()
        {
            Console.Write(solution(4));
        }
    }
}
