using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _14889
    {
        static int N;
        static int[,] S = new int[20,20];
        static int[] nums = new int[20];
        static int min = 1000000;

        static void BackTrack(int depth)
        {
            if(depth == N/2)
            {
                int score1, score2, diff;
                score1 = score2 = 0;

                for (int i = 0; i < N; i++)
                {
                    if (nums[i] != -1)
                    {
                        for (int j = i + 1; j < N; j++)
                        {
                            if (nums[j] != -1)
                            {
                                score1 += S[i, j] + S[j, i];
                            }
                        }
                    }
                    else
                    {
                        for (int j = i + 1; j < N; j++)
                        {
                            if (nums[j] == -1)
                            {
                                score2 += S[i, j] + S[j, i];
                            }
                        }
                    }
                }

                diff = Math.Abs(score1 - score2);

                if (min > diff)
                {
                    min = diff;
                }

                return;
            }
            else
            {
                for(int i=0; i<N; i++)
                {
                    if(nums[i] != -1)
                    {
                        nums[i] = -1;
                        BackTrack(depth + 1);
                        nums[i] = i+1;
                    }
                }
            }
        }
        static void Main()
        {
            string[] read;
            //N입력
            N = int.Parse(Console.ReadLine());

            //S입력
            for(int i=0; i<N; i++)
            {
                read = Console.ReadLine().Split(" ");

                nums[i] = i + 1;
                
                for(int j=0; j<read.Length; j++)
                {
                    S[i, j] = int.Parse(read[j]);
                }
            }

            BackTrack(0);

            Console.WriteLine(min);
        }
    }
}
