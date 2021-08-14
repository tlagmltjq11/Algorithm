using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 섬_연결하기
    {
        struct edge
        {
            public int from;
            public int to;
            public int dist;

            public edge(int f, int t, int  d)
            {
                from = f;
                to = t;
                dist = d;
            }
        }

        static int[] parent;

        static void Union(int a, int b)
        {
            int root1 = Find(a);
            int root2 = Find(b);

            if (root1 != root2)
            {
                parent[root1] = root2;
            }
        }

        static int Find(int cur)
        {
            if (parent[cur] == cur)
            {
                return cur;
            }

            return parent[cur] = Find(parent[cur]);
        }

        static void Set_Init(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                parent[i] = i;
            }
        }

        static int solution(int n, int[,] costs)
        {
            int answer = 0;
            List<edge> list = new List<edge>();
            int size = costs.GetLength(0);

            for (int i=0; i< size; i++)
            {
                list.Add(new edge(costs[i, 0], costs[i, 1], costs[i, 2]));
            }

            //dist 기준으로 정렬
            list.Sort((x1, x2) => x1.dist.CompareTo(x2.dist));

            //Union - Find 알고리즘 셋팅
            parent = new int[n + 1];
            Set_Init(n);

            //크루스칼 알고리즘
            int cnt = 0;
            int iter = 0;

            while(cnt < n - 1) //정점갯수-1 개 만큼의 간선을 선택하면 종료
            {
                edge cur = list[iter];
                if(Find(cur.from) != Find(cur.to))
                {
                    Union(cur.from, cur.to);
                    answer += cur.dist;
                    cnt++;
                }
                iter++;
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(4, new int[,] { { 0, 1, 1 }, { 0, 2, 2 }, { 1, 2, 5 }, { 1, 3, 1 }, { 2, 3, 8 } }));
        }
    }
}
