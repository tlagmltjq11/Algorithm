using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2667
    {
        static int n;
        static int[,] mat;
        static bool[,] visited; //재방문은 없기에 굳이 bool배열을 사용하지않고 mat값을 0으로 바꿔줘도 된다.
        static int cnt = 0;

        static void DFS(int i, int j)
        {
            visited[i, j] = true;
            cnt++;

            if((i - 1) >= 0 && mat[i-1, j] == 1)
            {
                if(visited[i-1, j] == false)
                    DFS(i - 1, j);
            }

            if((i + 1) < n && mat[i+1, j] == 1)
            {
                if (visited[i + 1, j] == false)
                    DFS(i + 1, j);
            }

            if ((j - 1) >= 0 && mat[i, j-1] == 1)
            {
                if (visited[i, j - 1] == false)
                    DFS(i, j - 1);
            }

            if ((j + 1) < n && mat[i, j+1] == 1)
            {
                if (visited[i, j + 1] == false)
                    DFS(i, j + 1);
            }
        }

        static void Main()
        {
            n = int.Parse(Console.ReadLine());
            mat = new int[n, n];
            visited = new bool[n, n];

            for(int i=0; i<n; i++)
            {
                string read = Console.ReadLine();

                for(int j=0; j<n; j++)
                {
                    visited[i,j] = false;
                    mat[i, j] = (int)char.GetNumericValue(read[j]);
                }
            }


            int totalGroup = 0;
            List<int> cnts = new List<int>();

            for (int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if(visited[i,j] == false && mat[i,j] == 1)
                    {
                        totalGroup++; //단지 수 +1
                        DFS(i, j); //단지 내 모든 인접한 정점 순회
                        cnts.Add(cnt); //단지 내 정점 수 리스트에 추가

                        cnt = 0; //초기화
                    }
                }
            }

            cnts.Sort();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(totalGroup.ToString());

            for(int i=0; i<cnts.Count; i++)
            {
                sb.AppendLine(cnts[i].ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
