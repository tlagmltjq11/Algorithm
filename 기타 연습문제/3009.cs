using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _3009
    {
        static void Main()
        {
            string[] x = new string[3];
            string[] y = new string[3];

            for(int i=0; i<3; i++)
            {
                string[] data = Console.ReadLine().Split(" ");

                x[i] = data[0];
                y[i] = data[1];
            }

            if(x[0] == x[1])
            {
                Console.Write(x[2]);
            }
            else if(x[0] == x[2])
            {
                Console.Write(x[1]);
            }
            else
            {
                Console.Write(x[0]);
            }

            Console.Write(" ");

            if (y[0] == y[1])
            {
                Console.Write(y[2]);
            }
            else if (y[0] == y[2])
            {
                Console.Write(y[1]);
            }
            else
            {
                Console.Write(y[0]);
            }
        }
    }
}
