using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1018
    {
        static void Main()
        {
            string[] NM = Console.ReadLine().Split(" ");
            int N = int.Parse(NM[0]);
            int M = int.Parse(NM[1]);
            string[] WB = new string[N];
            int Bstart;
            int Wstart;
            int min = 64;

            for (int i=0; i<N; i++)
            {
                WB[i] = Console.ReadLine();
            }
            
            for(int i=0; i<N-8+1; i++)
            {
                for(int j=0; j<M-8+1; j++)
                {
                    Bstart = 0; //index값이 짝수일때 검은색, 홀수일때 흰색
                    Wstart = 0; //index값이 홀수일때 검은색, 짝수일때 흰색

                    for(int a=i; a<i+8; a++)
                    {
                        for(int b=j; b<j+8; b++)
                        {
                            if((a+b) % 2 == 0)
                            {
                                if(WB[a][b].Equals('B'))
                                {
                                    Wstart++; //흰색 시작일 경우 짝수가 흰색이기 때문
                                }
                                else
                                {
                                    Bstart++; //검은색 시작일 경우 짝수가 검은색이기 때문
                                }
                            }
                            else
                            {
                                if (WB[a][b].Equals('B'))
                                {
                                    Bstart++; //검은색 시작일 경우 홀수가 흰색이기 때문
                                }
                                else
                                {
                                    Wstart++; //흰색 시작일 경우 홀수가 검은색이기 때문
                                }
                            }
                        }
                    }

                    if(min > Bstart)
                    {
                        min = Bstart;
                    }

                    if(min > Wstart)
                    {
                        min = Wstart;
                    }
                }
            }

            Console.WriteLine(min);

        }
    }
}
