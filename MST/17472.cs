using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _17472
    {
        struct Edge
        {
            public int src, dest, dist;

            public Edge(int src, int dest, int dist)
            {
                this.src = src;
                this.dest = dest;
                this.dist = dist;
            }
        }

        static void DFS(int x, int y)
        {
            if(map[x,y] == 0 || visited[x,y] == true)
            {
                return;
            }

            map[x, y] = island;
            visited[x, y] = true;

            if(x-1 >= 0 && map[x-1, y] == 1)
            {
                DFS(x - 1, y);
            }

            if(x+1 < n && map[x+1, y] == 1)
            {
                DFS(x + 1, y);
            }

            if (y - 1 >= 0 && map[x, y-1] == 1)
            {
                DFS(x, y - 1);
            }

            if (y + 1 < m && map[x, y + 1] == 1)
            {
                DFS(x, y + 1);
            }
        }

        static void Union(int a, int b)
        {
            int root1 = Find(a);
            int root2 = Find(b);

            if(root1 != root2)
            {
                parent[root1] = root2;
            }
        }

        static int Find(int a)
        {
            if(parent[a] == a)
            {
                return a;
            }

            return parent[a] = Find(parent[a]);
        }


        static int[] dx = { 0, -1, 0, 1 };
        static int[] dy = { -1, 0, 1, 0 };

        static void MakeBridge(int x, int y, int island)
        {
            for(int i=0; i<4; i++)
            {
                int start_x = x;
                int start_y = y;
                int dist = 0;

                while(true)
                {
                    start_x += dx[i];
                    start_y += dy[i];

                    //인덱스 범위가 벗어나거나 동일한 섬 내 좌표라면 break;
                    if(0 > start_x || start_x >= n || 0 > start_y || start_y >= m || map[start_x, start_y] == island)
                    {
                        break;
                    }

                    //인덱스 범위도 맞고 해당 좌표가 바다라면 다리 길이 ++
                    if(map[start_x, start_y] == 0)
                    {
                        dist++;
                        continue;
                    }
                    
                    //인덱스 범위도 맞고 해당 좌표가 동일한 섬 내 좌표도 아니라면 즉 다른 섬이라면
                    if(map[start_x, start_y] != 0)
                    {
                        //다리길이는 최소 2 이상
                        if(dist > 1)
                        {
                            Edge temp = new Edge(island, map[start_x, start_y], dist);
                            edge_List.Add(temp);
                            break;
                        }

                        //다리길이가 1이라면 추가하지 않음.
                        break;
                    }
                }
            }
        }

        static int[,] map;
        static bool[,] visited;
        static int island = 1;
        static int n, m;

        static int[] parent;

        static List<Edge> edge_List = new List<Edge>();

        static void Main()
        {
            string[] read = Console.ReadLine().Split(" ");
            n = int.Parse(read[0]);
            m = int.Parse(read[1]);

            map = new int[n, m];
            visited = new bool[n, m];

            for(int i=0; i<n; i++)
            {
                read = Console.ReadLine().Split(" ");

                for(int j=0; j<m; j++)
                {
                    map[i, j] = int.Parse(read[j]);
                }
            }


            //DFS를 통해서 섬에 번호 부여하기.
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<m; j++)
                {
                    if(map[i,j] != 0 && visited[i, j] == false)
                    {
                        DFS(i, j);
                        island++; //섬 번호 ++
                    }
                }
            }
            
            //가능한 모든 다리(간선)를 구해 리스트에 저장.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(map[i,j] != 0)
                    {
                        MakeBridge(i, j, map[i, j]);
                    }
                }
            }

            //유니온-파인드 배열 초기화
            parent = new int[island];
            for(int i=0; i<island; i++)
            {
                parent[i] = i;
            }

            //간선 리스트 오름차순 정렬
            edge_List.Sort((x1, x2) => x1.dist.CompareTo(x2.dist));

            int cnt = 0;
            int answer = 0;
            int iter = 0;

            while(cnt < island-2)
            {
                if(iter >= edge_List.Count)
                {
                    answer = -1;
                    break;
                }

                Edge temp = edge_List[iter];

                int root1 = Find(temp.src);
                int root2 = Find(temp.dest);

                if(root1 != root2)
                {
                    cnt++;
                    answer += temp.dist;
                    Union(temp.src, temp.dest);
                }

                iter++;
            }


            Console.WriteLine(answer);
        }
    }
}
