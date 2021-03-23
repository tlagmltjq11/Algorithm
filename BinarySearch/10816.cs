using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _10816
    {
        static int[] ns;

        static int lower_bound(int k)
        {
            int left = 0;
            int right = ns.Length - 1;
            int mid;

            while(left < right)
            {
                mid = (left + right) / 2;

                if(ns[mid] >= k)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return right;
        }

        static int upper_bound(int k)
        {
            int left = 0;
            int right = ns.Length - 1;
            int mid;

            while (left < right)
            {
                mid = (left + right) / 2;

                if (ns[mid] > k)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            if(ns[right] == k)
            {
                right++;
            }

            return right;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            ns = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), s => int.Parse(s));

            int m = int.Parse(Console.ReadLine());
            int[] ms = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), s => int.Parse(s));

            Array.Sort(ns);

            StringBuilder sb = new StringBuilder();

            for(int i=0; i<m; i++)
            {
                int k = ms[i];
                int low = lower_bound(k);
                int up = upper_bound(k);

                sb.Append((up - low).ToString() + " ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
