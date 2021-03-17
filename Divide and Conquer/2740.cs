using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class _2740
    {
        static int[,] Multi(int[,] a, int[,] b)
        {
            int[,] result = new int[a.GetLength(0), b.GetLength(1)];

            for(int i=0; i<a.GetLength(0); i++)
            {
                for(int j=0; j<b.GetLength(1); j++)
                {
                    int temp = 0;

                    for(int k=0; k<a.GetLength(1); k++)
                    {
                        temp += a[i, k] * b[k, j];
                    }

                    result[i, j] = temp;
                }
            }

            return result;
        }

        static void Main()
        {
            string[] read;
            int ar, ac;
            int br, bc;
            int[,] a, b, c;

            read = Console.ReadLine().Split(" ");
            ar = int.Parse(read[0]);
            ac = int.Parse(read[1]);

            a = new int[ar, ac];
            for(int i=0; i<ar; i++)
            {
                read = Console.ReadLine().Split(" ");
                for(int j=0; j<ac; j++)
                {
                    a[i, j] = int.Parse(read[j]);
                }
            }

            read = Console.ReadLine().Split(" ");
            br = int.Parse(read[0]);
            bc = int.Parse(read[1]);

            b = new int[br, bc];
            for (int i = 0; i < br; i++)
            {
                read = Console.ReadLine().Split(" ");
                for (int j = 0; j < bc; j++)
                {
                    b[i, j] = int.Parse(read[j]);
                }
            }

            c = Multi(a, b);

            StringBuilder sb = new StringBuilder();
            for(int i=0; i<c.GetLength(0); i++)
            {
                for(int j=0; j<c.GetLength(1); j++)
                {
                    sb.Append(c[i, j].ToString() + " ");
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
    */
}
