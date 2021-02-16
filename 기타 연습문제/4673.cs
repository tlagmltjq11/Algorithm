using System;

namespace CodingTestPractice
{
    //4673 셀프넘버
    class Program
    {
        static int D(int n)
        {
            int result = 0;

            while (n != 0)
            {
                result += n % 10;
                n /= 10;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] data = new int[10001];

            for (int i = 1; i < 10000; i++)
            {
                int cNum = D(i) + i;

                if (cNum <= 10000)
                {
                    data[cNum] = 1;
                }
            }

            for (int i = 1; i <= 10000; i++)
            {
                if (data[i] == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
