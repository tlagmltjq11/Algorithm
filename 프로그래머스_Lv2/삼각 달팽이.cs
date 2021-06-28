using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 삼각_달팽이
    {
        static int[] solution(int n)
        {
            int size = (n * (n + 1)) / 2;
            int[] answer = new int[size];
            int[,] tri = new int[n,n];

            int cur = 1;
            int x = -1, y = 0;

            for(int i=0; i<n; i++)
            {
                //진행할수록 횟수는 1씩 줄어들기 때문에 i부터 시작
                for(int j=i; j<n; j++)
                {
                    //왼쪽아래 오른쪽 왼쪽위 순서로 3번 진행하기에 %3으로 순서를 표시
                    //왼쪽아래
                    if(i%3 == 0)
                    {
                        x++;
                    }
                    //오른쪽
                    else if(i%3 == 1)
                    {
                        y++;
                    }
                    //왼쪽위
                    else if(i%3 == 2)
                    {
                        x--;
                        y--;
                    }

                    tri[x, y] = cur++;
                }
            }

            int iter = 0;
            for(int i=0; i<tri.GetLength(0); i++)
            {
                for(int j=0; j<tri.GetLength(1); j++)
                {
                    if(tri[i, j] == 0)
                    {
                        break;
                    }

                    answer[iter] = tri[i, j];
                    iter++;
                }
            }

            return answer;
        }
        static void Main()
        {
            int[] result = solution(4);
            for(int i=0; i<result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
