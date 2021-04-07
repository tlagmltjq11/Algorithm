using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{

    class _7576
    {
        static int[,] mat;
        static List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();
        static int n, m;

        static int BFS()
        {
            Queue<KeyValuePair<int, int>> q = new Queue<KeyValuePair<int, int>>();
            
            for(int i=0; i<list.Count; i++)
            {
                q.Enqueue(list[i]);
            }

            int cnt = 0;

            while(q.Count != 0)
            {
                int size = q.Count;

                //최소일수를 구하기 위해 사용한 아래 for문을
                //배열에 날짜를 누적해가는 식으로 풀면 없앨 수 있다.
                for(int a=0; a<size; a++)
                {
                    KeyValuePair<int, int> temp = q.Dequeue();

                    int i = temp.Key;
                    int j = temp.Value;

                    if ((i - 1) >= 0 && mat[i - 1, j] == 0)
                    {
                        mat[i - 1, j] = 1;
                        q.Enqueue(new KeyValuePair<int, int>(i - 1, j));
                    }

                    if ((i + 1) < n && mat[i + 1, j] == 0)
                    {
                        mat[i + 1, j] = 1;
                        q.Enqueue(new KeyValuePair<int, int>(i + 1, j));
                    }

                    if ((j - 1) >= 0 && mat[i, j - 1] == 0)
                    {
                        mat[i, j - 1] = 1;
                        q.Enqueue(new KeyValuePair<int, int>(i, j - 1));
                    }

                    if ((j + 1) < m && mat[i, j + 1] == 0)
                    {
                        mat[i, j + 1] = 1;
                        q.Enqueue(new KeyValuePair<int, int>(i, j + 1));
                    }
                }

                cnt++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i, j] == 0)
                    {
                        return -1;
                    }
                }
            }

            return cnt - 1;
        }

        static void Main()
        {
            string[] read = Console.ReadLine().Split(" ");
            n = int.Parse(read[1]);
            m = int.Parse(read[0]);

            mat = new int[n, m];

            for(int i=0; i<n; i++)
            {
                read = Console.ReadLine().Split(" ");
                for(int j=0; j<m; j++)
                {
                    int temp = int.Parse(read[j]);
                    mat[i, j] = temp;

                    if(temp == 1)
                    {
                        list.Add(new KeyValuePair<int, int>(i, j));
                    }
                }
            }

            Console.WriteLine(BFS());
        }
    }
}
