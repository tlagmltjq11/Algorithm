using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1931
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int[]> list = new List<int[]>();

            for(int i=0; i<n; i++)
            {
                string[] read = Console.ReadLine().Split(" ");
                list.Add(new int[] { int.Parse(read[0]), int.Parse(read[1]) });
            }

            list.Sort((n1, n2) =>
            {
                if (n1[1] == n2[1]) //끝나는 시간이 같은 경우
                {
                    return n1[0].CompareTo(n2[0]); //시작시간으로 정렬
                }
                else
                {
                    return n1[1].CompareTo(n2[1]);
                }
            });

            int result = 1;
            int prev = list[0][1];

            for(int i=1; i<n; i++)
            {
                if(list[i][0] >= prev)
                {
                    result++;
                    prev = list[i][1];
                }
            }

            Console.WriteLine(result);
        }
    }
}
