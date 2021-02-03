using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2580
    {
        static StringBuilder sb = new StringBuilder();
        static int[,] sudoku = new int[9, 9];
        //0값을 지닌 행,열을 저장
        static List<KeyValuePair<int, int>> target = new List<KeyValuePair<int, int>>();
        static bool complete = false; //스도쿠가 완성되었는지 판별
        static bool SquareCheck(int r, int c, int num)
        {
            r = r / 3; // 0~2 : 0  3~5 : 1  6~8 : 2 값이 나온다는 것을 이용
            c = c / 3; // 0~2 : 0  3~5 : 1  6~8 : 2 값이 나온다는 것을 이용

            //해당 r, c값으로 몇번째 사각형에 속한지 알 수 있게됨.

            //r * 3 -> 0, 3, 6부터 시작하게됨
            //+ 3 을 해줌으로써, 0~2, 3~5, 6~8까지 수행이 가능하게됨.
            for (int rr = r * 3; rr < (r * 3) + 3; rr++)
            {
                for (int cc = c * 3; cc < (c * 3) + 3; cc++)
                {
                    if (sudoku[rr, cc] == num)
                    {
                        //이미 같은 값이 있으므로 false
                        return false;
                    }
                }
            }
            return true;
        }
        
        static void BackTrack(int cnt)
        {
            //모든 스도쿠를 채웠다면 출력 후 반환.
            if(cnt == target.Count)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        sb.Append(sudoku[i, j] + " ");
                    }

                    sb.AppendLine();
                }

                Console.WriteLine(sb.ToString());
                complete = true; //스도쿠의 완성을 알림

                return;
            }
            else
            {
                //이미 스도쿠판이 완성되었으면 종료
                if(complete)
                {
                    return;
                }

                //1~9까지 숫자를 고른다.
                for (int i = 1; i <= 9; i++)
                {
                    //0값이 들어있던 좌표를 cnt 순서대로 꺼내옴
                    int x = target[cnt].Key;
                    int y = target[cnt].Value;

                    bool check = true;

                    for (int j = 0; j < 9; j++)
                    {
                        //가로 세로 검사
                        if((i == sudoku[x, j]) || (i == sudoku[j,y]))
                        {
                            //같은 값이 있으므로 false
                            check = false;
                        }
                    }

                    //사각형 내부 검사까지 통과한 경우만
                    if(check && SquareCheck(x, y, i))
                    {
                        sudoku[x, y] = i; //배열에 해당값 삽입
                        BackTrack(cnt + 1); //비어있는 다음 스도쿠 재귀
                        sudoku[x, y] = 0; //최종값을 찾지못한 경우 빠져나오면서 초기화
                    }
                }
            }
        }

        static void Main()
        {
            for (int i=0; i<9; i++)
            {
                string[] read = Console.ReadLine().Split(" ");
                int[] arr = Array.ConvertAll(read, s => int.Parse(s));

                for(int j=0; j<9; j++)
                {
                    sudoku[i, j] = arr[j];

                    if(arr[j] == 0)
                    {
                        //0값 좌표 추가
                        target.Add(new KeyValuePair<int, int>(i, j));
                    }
                }
            }

            BackTrack(0);
        }
    }
}
