using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _10816_test
    {
        static int[] ns;
        static int cnt = 0;

        static void BS(int left, int right, int key)
        {
            if (left > right)
            {
                return;
            }

            int mid = (left + right) / 2;

            if(ns[mid] == key)
            {
                cnt++;

                BS(left, mid - 1, key);
                BS(mid + 1, right, key);
            }
            else if(ns[mid] > key)
            {
                BS(left, mid - 1, key);
            }
            else
            {
                BS(mid + 1, right, key);
            }
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            ns = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), s => int.Parse(s));

            int m = int.Parse(Console.ReadLine());
            int[] ms = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), s => int.Parse(s));

            Array.Sort(ns);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < m; i++)
            {
                int k = ms[i];
                BS(0, n - 1, k);
                sb.Append(cnt.ToString() + " ");

                cnt = 0;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
