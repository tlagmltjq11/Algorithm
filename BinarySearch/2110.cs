using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice.NewFolder
{
    class _2110
    {
        static void Main()
        {
            int n, c;
            string[] read = Console.ReadLine().Split(" ");
            n = int.Parse(read[0]);
            c = int.Parse(read[1]);

            int[] cord = new int[n];

            for(int i=0; i<n; i++)
            {
                cord[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(cord);

            int left = 1;
            int right = cord[n - 1] - cord[0];

            while(left <= right)
            {
                int mid = (left + right) / 2;
                int start = 0;
                int cnt = 1;
                //가장 인접한 공유기의 최대거리가 3이려면 3보다 크거나 같게 설치해야한다.
                
                for(int i=start + 1; i<n; i++)
                {
                    if(cord[i] - cord[start] >= mid)
                    {
                        cnt++;
                        start = i;
                    }
                }

                if(cnt >= c)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            Console.WriteLine(right);
        }
    }
}
