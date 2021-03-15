using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class _1992
    {
        static int[,] arr;
        static StringBuilder sb = new StringBuilder();

        static void Divide(int n, int r, int c)
        {
            for(int i=r; i<n+r; i++)
            {
                for(int j=c; j<n+c; j++)
                {
                    if(arr[r,c] != arr[i,j])
                    {
                        sb.Append("(");
                        Divide(n / 2, r, c);
                        Divide(n / 2, r, c + n / 2);
                        Divide(n / 2, r + n / 2, c);
                        Divide(n / 2, r + n / 2, c + n / 2);
                        sb.Append(")");

                        return;
                    }
                }
            }

            if (arr[r, c].Equals('0'))
            {
                sb.Append("0");
            }
            else
            {
                sb.Append("1");
            }
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            arr = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string read = Console.ReadLine();

                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = Convert.ToInt32(read[j]);
                }
            }

            Divide(n, 0, 0);

            Console.WriteLine(sb.ToString());
        }
    }
    */
}
