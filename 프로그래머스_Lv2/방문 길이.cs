using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 방문_길이
    {
        struct edge
        {
            int startX, startY;
            int endX, endY;
        }

        static int solution(string dirs)
        {
            int answer = 0;
            // fromX, fromY, toX, toY
            bool[,,,] board = new bool[11, 11, 11, 11];

            int idx = 0;
            int dirsLen = dirs.Length;

            int curX = 5;
            int curY = 5;

            while (idx < dirsLen)
            {
                char dir = dirs[idx];
                if (dir == 'U')
                {
                    if (curY + 1 < 11)
                    {
                        if (board[curX,curY,curX,curY + 1] != true)
                        {
                            // 간선의 방문여부를 체크해야 하기 때문에 양방향 다 방문으로 체크
                            board[curX, curY, curX, curY + 1] = true;
                            board[curX, curY + 1, curX, curY] = true;
                            answer++;
                        }
                        curY++;
                    }
                }

                else if (dir == 'D')
                {
                    if (curY - 1 >= 0)
                    {
                        if (board[curX, curY, curX, curY - 1] != true)
                        {
                          
                            board[curX, curY, curX, curY - 1] = true;
                            board[curX, curY - 1, curX, curY] = true;
                            answer++;
                        }
                        curY--;
                    }
                }

                else if (dir == 'L')
                {
                    if (curX - 1 >= 0)
                    {
                        if (board[curX, curY, curX - 1, curY] != true)
                        {
                           
                            board[curX, curY, curX - 1, curY] = true;
                            board[curX - 1, curY, curX, curY] = true;
                            answer++;
                        }
                        curX--;
                    }
                }

                else if (dir == 'R')
                {
                    if (curX + 1 < 11)
                    {
                        if (board[curX, curY, curX + 1, curY] != true)
                        {
                            board[curX, curY, curX + 1, curY] = true;
                            board[curX + 1, curY, curX, curY] = true;
                            answer++;
                        }
                        curX++;
                    }
                }

                idx++;
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution("LULLLLLLU"));
        }
    }
}
