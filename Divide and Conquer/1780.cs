using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class _1780
    {
        static int[,] arr;
        static int n1, n2, n3;

        static void Divide(int n, int r, int c)
        {
            for(int i=r; i<n + r; i++)
            {
                for(int j=c; j<n + c; j++)
                {
                    if(arr[r, c] != arr[i, j])
                    {
                        Divide(n / 3, r, c);
                        Divide(n / 3, r + n / 3, c);
                        Divide(n / 3, r + 2 * n / 3, c);
                        Divide(n / 3, r, c + n / 3);
                        Divide(n / 3, r, c + 2 * n / 3);
                        Divide(n / 3, r + n / 3, c + n / 3);
                        Divide(n / 3, r + n / 3, c + 2 * n / 3);
                        Divide(n / 3, r + 2 * n / 3, c + n / 3);
                        Divide(n / 3, r + 2 * n / 3, c + 2 * n / 3);
                        return;
                    }
                }
            }

            if(arr[r,c] == -1)
            {
                n1++;
            }
            else if(arr[r,c] == 0)
            {
                n2++;
            }
            else
            {
                n3++;
            }

            return;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            arr = new int[n, n];

            for(int i=0; i<n; i++)
            {
                string[] read = Console.ReadLine().Split(" ");

                for(int j=0; j<n; j++)
                {
                    arr[i, j] = int.Parse(read[j]);
                }
            }

            Divide(n, 0, 0);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
        }
    }
    */
}
