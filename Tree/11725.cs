using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class tree
    {
        int n; // 노드의 개수
        List<int>[] list; //노드간 연결 정보 저장
        int[] parents; //부모노드 저장
        bool[] visited; //방문체크

        public tree(int n)
        {
            this.n = n;
            list = new List<int>[n + 1];
            parents = new int[n + 1];
            visited = new bool[n + 1];

            for(int i=1; i<=n; i++)
            {
                list[i] = new List<int>();
            }
        }

        public void insert_edge(int start, int end)
        {
            list[start].Add(end);
            list[end].Add(start);
        }

        public void Find_Parents(int v)
        {
            visited[v] = true;

            for(int i=0; i<list[v].Count; i++)
            {
                if(visited[list[v][i]] == false)
                {
                    parents[list[v][i]] = v;
                    Find_Parents(list[v][i]);
                }
            }
        }

        public void Print_Parents()
        {
            StringBuilder sb = new StringBuilder();
            for(int i=2; i<=n; i++)
            {
                sb.AppendLine(parents[i].ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }


    class _11725
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            tree t = new tree(n);

            string[] read;
            for(int i=0; i<n-1; i++)
            {
                read = Console.ReadLine().Split(" ");
                t.insert_edge(int.Parse(read[0]), int.Parse(read[1]));
            }

            t.Find_Parents(1);
            t.Print_Parents();
        }
    }
}
