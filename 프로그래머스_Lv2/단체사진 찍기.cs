using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 단체사진_찍기
    {
        static int cnt = 0;
        static bool[] visited = new bool[8];
        static int[] position = new int[8];
        static Dictionary<char, int> dict = new Dictionary<char, int>();
        static string[] condition;

        //순열 - 서로 다른 n개의 숫자를 일려로 배열하는 모든 경우들
        static void Permutation(int depth)
        {
            //캐릭터들의 배치가 끝난 경우
            if(depth == 8)
            {
                //조건에 알맞는 배치인지 판단
                if(Check())
                {
                    //알맞다면 cnt++
                    cnt++;
                }

                return;
            }

            //배치가 끝나지 않았다면 계속 진행
            for(int i=0; i<8; i++)
            {
                //배치되지 않은 캐릭터인 경우
                if(!visited[i])
                {
                    visited[i] = true;
                    position[depth] = i; //배치
                    Permutation(depth + 1); //다음 캐릭터 배치를 위한 재귀호출
                    visited[i] = false;
                }
            }
        }

        static bool Check()
        {
            for(int i=0; i<condition.Length; i++)
            {
                int x = dict[condition[i][0]];
                int y = dict[condition[i][2]];
                char type = condition[i][3];
                int diff = condition[i][4] - '0';

                int xPos = position[x];
                int yPos = position[y];

                if (type == '=')
                {
                    if (Math.Abs(xPos - yPos) - 1 != diff)
                    {

                        return false;
                    }

                }
                else if (type == '>')
                {
                    if (Math.Abs(xPos - yPos) - 1 <= diff)
                    {

                        return false;
                    }


                }
                else if (type == '<')
                {
                    if (Math.Abs(xPos - yPos) - 1 >= diff)
                    {

                        return false;
                    }
                }
            }

            return true;
        }

        static int solution(int n, string[] data)
        {
            int answer = 0;

            dict.Add('A', 0);
            dict.Add('C', 1);
            dict.Add('F', 2);
            dict.Add('J', 3);
            dict.Add('M', 4);
            dict.Add('N', 5);
            dict.Add('R', 6);
            dict.Add('T', 7);

            condition = data;
            Permutation(0);
            answer = cnt;

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(2, new string[] { "N~F=0", "R~T>2" }));
        }
    }
}
