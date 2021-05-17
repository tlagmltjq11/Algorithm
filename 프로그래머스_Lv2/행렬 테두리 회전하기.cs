using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 행렬_테두리_회전하기
    {
        static int[,] matrix;

        static int[] solution(int rows, int columns, int[,] queries)
        {
            int[] answer = new int[] { };
            List<int> temp = new List<int>();

            matrix = new int[rows, columns];
            int num = 1;
            for(int i=0; i<rows; i++)
            {
                for(int j=0; j<columns; j++)
                {
                    matrix[i, j] = num;
                    num++;
                }
            }

            for(int i=0; i<queries.GetLength(0); i++)
            {
                int min = int.MaxValue;

                int x1 = queries[i, 0] - 1;
                int y1 = queries[i, 1] - 1;
                int x2 = queries[i, 2] - 1;
                int y2 = queries[i, 3] - 1;

                int iter = matrix[x1, y1];
                int t;
                for(int j=y1 + 1; j<=y2; j++)
                {
                    t = matrix[x1, j];
                    matrix[x1, j] = iter;
                    iter = t;

                    min = Math.Min(min, iter);
                }

                for(int j=x1 + 1; j<=x2; j++)
                {
                    t = matrix[j, y2];
                    matrix[j, y2] = iter;
                    iter = t;

                    min = Math.Min(min, iter);
                }

                for(int j=y2 - 1; j>=y1; j--)
                {
                    t = matrix[x2, j];
                    matrix[x2, j] = iter;
                    iter = t;

                    min = Math.Min(min, iter);
                }

                for(int j=x2 - 1; j>=x1; j--)
                {
                    t = matrix[j, y1];
                    matrix[j, y1] = iter;
                    iter = t;

                    min = Math.Min(min, iter);
                }

                temp.Add(min);
            }

            answer = temp.ToArray();
            return answer;
        }

        static void Main()
        {
            int[] result = solution(6, 6, new int[,] { { 2, 2, 5, 4 },{ 3, 3, 6, 6 },{ 5, 1, 6, 3 } });

            for(int i=0; i<result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
