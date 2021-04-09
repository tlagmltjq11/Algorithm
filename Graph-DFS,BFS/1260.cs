using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingTestPractice
{
	class Graph
	{
		int n; //정점의 개수
		bool[] visited; //방문했는지 체크
		int maxSize; //최대 정점 개수
		public List<int>[] adj_Link; //각 정점의 인접정점들을 저장해둔 리스트들의 배열

		public Graph(int maxVertex)
		{
			n = 0;
			maxSize = maxVertex;

			visited = new bool[maxSize + 1];
			adj_Link = new List<int>[maxSize + 1];
		}

		public void Init()
		{
			for (int i = 1; i < maxSize + 1; i++)
			{
				visited[i] = false;
			}
		}

		public void insert_Vertex(int vertex)
		{
			if ((n+1) > maxSize)
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

		public void DFS(int v, ref string result)
		{
			visited[v] = true;

			result += v.ToString() + " ";

			for(int i=0; i<adj_Link[v].Count; i++)
			{
				if (visited[adj_Link[v][i]] != true) //방문하지않은 인접리스트라면
				{
					DFS(adj_Link[v][i], ref result); //정점번호가 가장 작은 노드부터 DFS
				}
			}
		}

		public void BFS(int v, ref string result)
		{
			Queue<int> q = new Queue<int>();
			visited[v] = true;

			result += v.ToString() + " ";

			q.Enqueue(v);

			while (q.Count != 0)
			{
				v = q.Dequeue();

				for (int i = 0; i < adj_Link[v].Count; i++)
				{
					if (!visited[adj_Link[v][i]])
					{
						result += adj_Link[v][i].ToString() + " ";
						visited[adj_Link[v][i]] = true;
						q.Enqueue(adj_Link[v][i]);
					}
				}
			}
		}
	}


	class _1260
	{
		static void Main()
		{
			string[] read = Console.ReadLine().Split(" ");

			int v = int.Parse(read[0]);
			int e = int.Parse(read[1]);
			int start = int.Parse(read[2]);

			Graph g = new Graph(v);

			for (int i = 0; i < v; i++)
			{
				g.insert_Vertex(i + 1);
			}

			for (int i = 0; i < e; i++)
			{
				read = Console.ReadLine().Split(" ");
				int x1 = int.Parse(read[0]);
				int x2 = int.Parse(read[1]);

				g.insert_Edge(x1, x2);
			}

			//작은 정점 우선으로 방문하기 위해 모든 인접리스트를 정렬
			for(int i=1; i<v+1; i++)
            {
				g.adj_Link[i].Sort();
            }

			string result = "";
			g.DFS(start, ref result);
			Console.WriteLine(result);

			g.Init();

			result = "";
			g.BFS(start, ref result);
			Console.WriteLine(result);
		}
	}
}