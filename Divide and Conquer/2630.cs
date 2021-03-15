using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class _2630
    {
        static int w, b;
        static int[,] arr; 

        static void Divide(int n, int r, int c)
        {
            int temp = arr[r, c];

            for(int i=r; i<n + r; i++) // + r을 해줘야 r값부터 시작해 빨리 끝나는 것을 방지
            {
                for(int j=c; j<n + c; j++)
                {
                    if(arr[i, j] != temp)
                    {
                        Divide(n / 2, r, c);
                        Divide(n / 2, r, c + n / 2);
                        Divide(n / 2, r + n / 2, c);
                        Divide(n / 2, r + n / 2, c + n / 2);

                        return; //나누어진 사각형은 갯수 덧셈 방지.
                    }
                }
            }

            //전부 순회했을때 return되지 않은 즉 색이 전부 같은 경우
            if(temp == 0)
            {
                w++;
            }
            else
            {
                b++;
            }
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

            Console.WriteLine(w);
            Console.WriteLine(b);
        }
    }
    */
}
