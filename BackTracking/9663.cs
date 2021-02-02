using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _9663
    {
        static int N, result = 0;
        static int[] arr = new int[16];

        static bool canVisit(int row, int col)
        {
            //각 행마다 1개의 퀸만 존재할 수 있기 때문에
            //검사는 바로 위 행까지만 하면 된다.
            for(int i=1; i<row; i++)
            {
                //같은 열에 있거나, 대각선 이동반경에 포함이 된다면 false
                if(arr[i] == col || Math.Abs(arr[i] - col) == Math.Abs(row - i))
                {
                    return false;
                }
            }

            return true;
        }

        static void BackTrack(int row)
        {
            if (row == N)
            {
                result++; //모든 퀸을 배치한 경우니까 +1
            }
            else
            {
                for (int col = 1; col <= N; col++)
                {
                    if(canVisit(row + 1, col))
                    {
                        arr[row + 1] = col;
                        BackTrack(row + 1);
                    }
                }
            }
        }


        static void Main()
        {
            N = int.Parse(Console.ReadLine());
            BackTrack(0);

            Console.WriteLine(result);
        }
    }
}
