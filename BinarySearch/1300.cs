using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1300
    {
		static long n, k, res;

		static long biSearch(long left, long right)
		{
			long cnt = 0;
			long mid = (left + right) / 2;
			if (left > right) return res;
			for (int i = 1; i <= n; i++)
			{
				cnt += Math.Min(mid / i, n);
			}

			if (k <= cnt)
			{
				res = mid;
				return biSearch(left, mid - 1);
			}
			else
			{
				return biSearch(mid + 1, right);
			}
		}

		static void Main()
        {
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            long left = 1;
            long right = k;

			Console.WriteLine(biSearch(left, right));
        }
    }
}
