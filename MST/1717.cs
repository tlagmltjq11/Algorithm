using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1717
    {
        static int[] parent;
        static int n;

        static void Union(int a, int b)
        {
            int root1 = Find(a);
            int root2 = Find(b);

            if(root1 != root2)
            {
                parent[root1] = root2;
            }
        }

        static int Find(int cur)
        {
            if(parent[cur] == cur)
            {
                return cur;
            }

            return parent[cur] = Find(parent[cur]);
        }

        static void Set_Init()
        {
            for (int i = 1; i <= n; i++)
            {
                parent[i] = i;
            }
        }

        static void Main()
        {
            string[] read = Console.ReadLine().Split(" ");
            StringBuilder sb = new StringBuilder();

            n = int.Parse(read[0]);
            int m = int.Parse(read[1]);

            parent = new int[n + 1];
            Set_Init();

            for (int i=0; i<m; i++)
            {
                read = Console.ReadLine().Split(" ");

                if(int.Parse(read[0]) == 0)
                {
                    Union(int.Parse(read[1]), int.Parse(read[2]));
                }
                else
                {
                    int a = Find(int.Parse(read[1]));
                    int b = Find(int.Parse(read[2]));

                    if (a != b)
                    {
                        sb.AppendLine("NO");
                    }
                    else
                    {
                        sb.AppendLine("YES");
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
