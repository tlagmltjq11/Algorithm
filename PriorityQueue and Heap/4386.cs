using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _4386
    {
        //좌표
        class Coordi
        {
            public int num;
            public double x, y;

            public Coordi(int num, double x, double y)
            {
                this.num = num;
                this.x = x;
                this.y = y;
            }
        }

        //간선
        class Edge
        {
            public int start, end;
            public double weight;

            public Edge(int s, int e, double w)
            {
                start = s;
                end = e;
                weight = w;
            }
        }

        //Union - Find
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
        //

        //유니온-파인드를 위한 배열
        static int[] parent;


        //Main
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Coordi> vertex_List = new List<Coordi>(); //좌표리스트
            List<Edge> edge_List = new List<Edge>(); //간선리스트

            for(int i=0; i<n; i++)
            {
                string[] read = Console.ReadLine().Split(" ");

                //좌표 입력 후 추가
                vertex_List.Add(new Coordi(i, double.Parse(read[0]), double.Parse(read[1])));
            }


            //좌표간 모든 간선을 계산하여 간선리스트에 추가
            //좌표가 최대 100개 이하로 적은 수기 때문에 가능한 방식이다.
            for(int i=0; i<n; i++)
            {
                for(int j=i+1; j<n; j++)
                {
                    double weight = getDistance(vertex_List[i], vertex_List[j]);

                    edge_List.Add(new Edge(vertex_List[i].num, vertex_List[j].num, weight));
                }
            }

            //간선을 가중치를 기준으로 정렬
            edge_List.Sort((x1, x2) => x1.weight.CompareTo(x2.weight));

            //유니온-파인드 배열 초기화
            parent = new int[n];
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
            }

            //크루스칼 알고리즘 실행
            double answer = 0;
            for(int i=0; i<edge_List.Count; i++)
            {
                Edge edge = edge_List[i];

                //두 정점이 같은 집합에 속해있지 않은 경우
                if(Find(edge.start) != Find(edge.end))
                {
                    answer += edge.weight;
                    //해당 간선을 선택함과 동시에 두 정점이 속한 집합을 합쳐준다.
                    Union(edge.start, edge.end);
                }
            }

            Console.WriteLine(answer);
        }

        //피타고라스의 정리로 거리를 구한다.
        static double getDistance(Coordi c1, Coordi c2)
        {
            return Math.Sqrt(Math.Pow(c1.x - c2.x, 2) + Math.Pow(c1.y - c2.y, 2));
        }
    }
}
