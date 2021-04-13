using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
	class Graph
	{
		int n; //정점의 개수
		long[,] distance;
		int maxSize; //최대 정점 개수
		public List<KeyValuePair<long, int>>[] adj_Link; //각 정점의 인접정점들을 저장해둔 리스트들의 배열

		public Graph(int maxVertex)
		{
			n = 0;
			maxSize = maxVertex;

			distance = new long[maxSize, maxSize];
			adj_Link = new List<KeyValuePair<long, int>>[maxSize];
		}

		public void Init()
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if(i == j)
                    {
						distance[i, j] = 0;
					}
					else
                    {
						distance[i, j] = int.MaxValue;
					}
				}
			}
		}

		public void insert_Vertex(int vertex)
		{
			if ((n + 1) > maxSize)
			{
				//정점개수 초과 오류
				return;
			}

			adj_Link[n] = new List<KeyValuePair<long, int>>();
			n++;
		}

		public void insert_Edge(int start, int end, long weight)
		{
			if (start > n || end > n)
			{
				//정점 번호 오류
				return;
			}

			adj_Link[start - 1].Add(new KeyValuePair<long, int>(weight, end - 1));
			//adj_Link[end - 1].Add(new KeyValuePair<long, int>(weight, start - 1));
		}

		public void Floyd()
        {
			//초기화 작업
			Init();
			for(int i=0; i<n; i++)
            {
				for(int j=0; j< adj_Link[i].Count; j++)
                {
					//두 도시 사이에 여러개의 간선이 있을 수 있기 때문에 더 작을때만 변경해준다.
					if(distance[i, adj_Link[i][j].Value] > adj_Link[i][j].Key)
                    {
						distance[i, adj_Link[i][j].Value] = adj_Link[i][j].Key; //초기화
					}
                }
            }

			//Floyd
			for (int k = 0; k < n; k++)
			{
				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < n; j++)
					{
						if (distance[i, j] > distance[i, k] + distance[k, j])
						{
							distance[i, j] = distance[i, k] + distance[k, j];
						}
					}
				}
			}

			//출력
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if(distance[i, j] == int.MaxValue)
                    {
						sb.Append("0 ");
					}
					else
                    {
						sb.Append(distance[i, j].ToString() + " ");
					}
				}
				sb.AppendLine();
			}

			Console.WriteLine(sb.ToString());
		}
	}

	class _11404
    {
        static void Main()
        {
			int n = int.Parse(Console.ReadLine());
			int m = int.Parse(Console.ReadLine());

			Graph g = new Graph(n);
			for(int i=0; i<n; i++)
            {
				g.insert_Vertex(i);
            }

			for(int i=0; i<m; i++)
            {
				string[] read = Console.ReadLine().Split(" ");

				g.insert_Edge(int.Parse(read[0]), int.Parse(read[1]), long.Parse(read[2]));
            }

			g.Floyd();
        }
    }
}
