using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 가장_큰_정사각형_찾기
    {
        static int solution(int[,] board)
        {
            int answer = 0;

            for (int i = 1; i < board.GetLength(0); i++)
            {
                for (int j = 1; j < board.GetLength(1); j++)
                {
                    if (board[i,j] == 1)
                    {
                        int min = Math.Min(board[i - 1,j], Math.Min(board[i,j - 1], board[i - 1,j - 1]));
                        board[i,j] = min + 1;
                        answer = Math.Max(answer, board[i,j]);
                    }
                }
            }

            return answer * answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(new int[,] { { 0, 0, 1, 1 }, { 1, 1, 1, 1 } }));
        }
    }
}
