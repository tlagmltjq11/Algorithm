using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
	class Graph
	{
		int n; //정점의 개수
		int maxSize; //최대 정점 개수
		public int[] visited; //방문했는지 체크
		public List<int>[] adj_Link; //각 정점의 인접정점들을 저장해둔 리스트들의 배열

		public Graph(int maxVertex)
		{
			n = 0;
			maxSize = maxVertex;
			visited = new int[maxSize + 1];
			adj_Link = new List<int>[maxSize + 1];
		}

		public void insert_Vertex(int vertex)
		{
			if ((n + 1) > maxSize)
			{
				//정점개수 초과 오류
				return;
			}

			n++;

			adj_Link[n] = new List<int>();
		}

		public void insert_Edge(int start, int end)
		{
			if (start > n || end > n)
			{
				//정점 번호 오류
				return;
			}

			//양방향으로 간선 추가
			adj_Link[start].Add(end);
			adj_Link[end].Add(start);
		}

		public bool check(int start)
        {
			Queue<int> q = new Queue<int>();
			q.Enqueue(start);
			visited[start] = -1; //블루팀은 -1 레드팀은 1

			while(q.Count != 0)
            {
				int temp = q.Dequeue();

				for(int i=0; i<adj_Link[temp].Count; i++)
                {
					if(visited[adj_Link[temp][i]] == 0) //0이라면 아예 방문하지 않은 노드
                    {
						q.Enqueue(adj_Link[temp][i]);
						visited[adj_Link[temp][i]] = visited[temp] * -1; //-1을 곱해주면 반대팀이 됨.
					}
					//방문된적이 있는 노드라면 이분그래프인지 체크해야한다.
					else if(visited[adj_Link[temp][i]] + visited[temp] != 0) //다른팀이면 더한값이 0이 나와야한다.
                    {
						return false;
                    }
                }
            }

			return true;
        }
	}

	class _1707
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
			StringBuilder sb = new StringBuilder();

            for(int i=0; i<k; i++)
            {
                string[] read = Console.ReadLine().Split(" ");
                int v = int.Parse(read[0]);
                int e = int.Parse(read[1]);

				Graph g = new Graph(v);

				for(int j=0; j<v; j++)
                {
					g.insert_Vertex(j + 1);
                }

				for(int j=0; j<e; j++)
                {
					read = Console.ReadLine().Split(" ");
					g.insert_Edge(int.Parse(read[0]), int.Parse(read[1]));
				}

				bool result = false;

				for (int j=0; j<v; j++)
                {
					if(g.visited[j+1] == 0)
                    {
						result = g.check(j + 1);

						if (!result)
						{
							break;
						}
					}
                }

				if(result)
                {
					sb.AppendLine("YES");
                }
				else
                {
					sb.AppendLine("NO");
                }
            }

			Console.WriteLine(sb.ToString());
        }
    }
}
