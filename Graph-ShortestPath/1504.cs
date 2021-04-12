using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
	class Graph
	{
		int n; //정점의 개수
		bool[] visited; //방문했는지 체크
		int[] distance; //다익스트라에서 사용될 최단거리 배열
		int maxSize; //최대 정점 개수
		public List<KeyValuePair<int, int>>[] adj_Link; //각 정점의 인접정점들을 저장해둔 리스트들의 배열

		public Graph(int maxVertex)
		{
			n = 0;
			maxSize = maxVertex;

			visited = new bool[maxSize];
			distance = new int[maxSize];
			adj_Link = new List<KeyValuePair<int, int>>[maxSize];
		}

		public void Init()
		{
			for (int i = 0; i < maxSize; i++)
			{
				visited[i] = false;
				distance[i] = int.MaxValue;
			}
		}

		public void insert_Vertex(int vertex)
		{
			if ((n + 1) > maxSize)
			{
				//정점개수 초과 오류
				return;
			}
			adj_Link[n] = new List<KeyValuePair<int, int>>();
			n++;
		}

		public void insert_Edge(int start, int end, int weight)
		{
			if (start > n || end > n)
			{
				//정점 번호 오류
				return;
			}

			adj_Link[start - 1].Add(new KeyValuePair<int, int>(weight, end - 1));
			adj_Link[end - 1].Add(new KeyValuePair<int, int>(weight, start - 1));
		}

		public int Dijkstra(int start, int end)
		{
			for (int i = 0; i < adj_Link[start-1].Count; i++)
			{
				distance[adj_Link[start-1][i].Value] = adj_Link[start - 1][i].Key;
			}

			distance[start-1] = 0;
			visited[start-1] = true;

			//다익스트라는 노드가 n개일때 n-1번이면 모든 최단거리를 구할 수 있음.
			for (int i = 0; i < n - 1; i++)
			{
				int min = int.MaxValue;
				int min_index = -1;

				//방문하지 않은 노드 중 최소값을 찾는다.
				for (int j = 0; j < maxSize; j++)
				{
					if (visited[j] == false && distance[j] < min)
					{
						min = distance[j];
						min_index = j;
					}
				}

				if (min_index == -1)
				{
					break;
				}

				visited[min_index] = true;
				for (int j = 0; j < adj_Link[min_index].Count; j++)
				{
					if (visited[adj_Link[min_index][j].Value] == false)
					{
						if (distance[adj_Link[min_index][j].Value] > adj_Link[min_index][j].Key + distance[min_index])
						{
							distance[adj_Link[min_index][j].Value] = adj_Link[min_index][j].Key + distance[min_index];
						}
					}
				}
			}

			return distance[end-1];
		}
	}

	class _1504
    {
        static void Main()
        {
            string[] read = Console.ReadLine().Split(" ");

            int n = int.Parse(read[0]);
            int e = int.Parse(read[1]);

			Graph g = new Graph(n);
			g.Init();

			for(int i=0; i<n; i++)
            {
				g.insert_Vertex(i);
            }

            for(int i=0; i<e; i++)
            {
                read = Console.ReadLine().Split(" ");
                int u = int.Parse(read[0]);
                int v = int.Parse(read[1]);
                int w = int.Parse(read[2]);

				g.insert_Edge(u, v, w);
            }

			read = Console.ReadLine().Split(" ");
			int n1 = int.Parse(read[0]);
			int n2 = int.Parse(read[1]);

			// 1 -> n1 -> n2 -> n
			int temp1 = 0;
			temp1 += g.Dijkstra(1, n1);
			temp1 += g.Dijkstra(n1, n2);
			temp1 += g.Dijkstra(n2, n);

			// 1 -> n2 -> n1 -> n
			int temp2 = 0;
			temp2 += g.Dijkstra(1, n2);
			temp2 += g.Dijkstra(n2, n1);
			temp2 += g.Dijkstra(n1, n);

			int result = Math.Min(temp1, temp2);

			if(result == int.MaxValue)
            {
				Console.WriteLine(-1);
            }
			else
            {
				Console.WriteLine(result);
            }
		}
    }
}
