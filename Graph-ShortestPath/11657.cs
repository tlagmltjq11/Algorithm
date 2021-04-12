using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
	class Graph
	{
		int n; //정점의 개수
		long[] distance;
		int maxSize; //최대 정점 개수
		public List<KeyValuePair<long, int>>[] adj_Link; //각 정점의 인접정점들을 저장해둔 리스트들의 배열

		public Graph(int maxVertex)
		{
			n = 0;
			maxSize = maxVertex;

			distance = new long[maxSize];
			adj_Link = new List<KeyValuePair<long, int>>[maxSize];
		}

		public void Init()
		{
			for (int i = 0; i < maxSize; i++)
			{
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
		}

		public void BellmanFord(int start)
        {
			for (int i = 0; i < n; i++)
			{
				distance[i] = int.MaxValue; //초기화
			}
			distance[start-1] = 0;

			for (int i = 0; i < n; i++) //정점 갯수 만큼
			{
				for (int j = 0; j < n; j++) //이하 2중 루프는 모든 간선을 인접리스트 방식으로 순회하기 위함.
				{
					for(int k=0; k<adj_Link[j].Count; k++)
					{
						if (distance[j] == int.MaxValue)
						{
							//시작점이 무한대인 경우는 어차피 결과가 무한대이므로 넘어감.
							continue;
						}

						distance[adj_Link[j][k].Value] = Math.Min(distance[adj_Link[j][k].Value], distance[j] + adj_Link[j][k].Key);
					}
				}
			}

			//음의 사이클이 존재하는지 확인하기 위해 한번의 사이클을 더 돌려본다.
			for (int j = 0; j < n; j++)
			{
				for (int k = 0; k < adj_Link[j].Count; k++)
				{
					if (distance[j] == int.MaxValue)
					{
						//시작점이 무한대인 경우는 어차피 결과가 무한대이므로 넘어감.
						continue;
					}

					if(distance[adj_Link[j][k].Value] > distance[j] + adj_Link[j][k].Key)
                    {
						Console.WriteLine(-1);
						return;
                    }
				}
			}

			//음의 사이클이 없다면
			StringBuilder sb = new StringBuilder();
			for(int i=1; i<n; i++)
            {
				if(distance[i] == int.MaxValue)
                {
					sb.AppendLine("-1");
				}
				else
                {
					sb.AppendLine(distance[i].ToString());
				}
            }

			Console.Write(sb.ToString());
		}
	}

	class _11657
    {
        static void Main()
        {
			string[] read = Console.ReadLine().Split(" ");
			int n = int.Parse(read[0]);
			int m = int.Parse(read[1]);

			Graph g = new Graph(n);
			g.Init();

			for(int i=0; i<n; i++)
            {
				g.insert_Vertex(i);
            }

			for(int i=0; i<m; i++)
            {
				read = Console.ReadLine().Split(" ");

				g.insert_Edge(int.Parse(read[0]), int.Parse(read[1]), long.Parse(read[2]));
            }

			g.BellmanFord(1);
        }
    }
}
