using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2775
    {
        
        static void Main(string[] args)
        {
            /*
            //첫번째코드 점화식을 찾지않고 직접구해버린 소스 하지만 통과함.
            
            int testCase = int.Parse(Console.ReadLine());

            for (int i=0; i<testCase; i++)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());

                int[] zero = new int[n+1];
                
                for(int j=1; j<=n; j++)
                {
                    zero[j] = j;
                }

                for(int j=0; j<k; j++)
                {
                    int sum = 0;

                    for(int kk=1; kk<=n; kk++)
                    {
                        sum += zero[kk];

                        zero[kk] = sum;
                    }
                }

                Console.WriteLine(zero[n]);

            }*/
            

            //d[i][j] = d[i-1][j] + d[i][j-1]이라는 점화식을 이용한 코드
            //오히려 메모리와 시간이 위에서 작성한 코드가 좋았음.
            int testCase = int.Parse(Console.ReadLine());

            int[,] d = new int[15, 15];

            for (int i = 1; i < 15; i++)
            {
                d[0,i] = i; //0층 초기화
            }

            for (int i = 1; i < 15; i++)
            {
                for (int j = 1; j < 15; j++)
                {
                    d[i, j] = d[i - 1, j] + d[i, j - 1];
                }
            }

            for (int i = 0; i < testCase; i++)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());


                Console.WriteLine(d[k,n]);
            }
        }
        
    }
}
