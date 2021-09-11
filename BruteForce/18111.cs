using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _18111
    {
        static void Main()
        {
            //변수 선언 및 입력--------------------------
            string[] nmb = Console.ReadLine().Split(" ");
            int n = int.Parse(nmb[0]);
            int m = int.Parse(nmb[1]);
            int b = int.Parse(nmb[2]);
            int[,] blocks = new int[n, m];

            //BruteForce 할 범위 
            // -> 최솟값보다 높이가 더 내려갈 이유가 없음 최댓값도 마찬가지
            int min = int.MaxValue;
            int max = int.MinValue;

            //최소시간과 최대높이
            int minTime = int.MaxValue;
            int maxHeight = -1;

            for(int i=0; i<n; i++)
            {
                nmb = Console.ReadLine().Split(" ");

                for(int j=0; j<m; j++)
                {
                    int val = int.Parse(nmb[j]);
                    blocks[i, j] = val;

                    max = Math.Max(max, val);
                    min = Math.Min(min, val);
                }
            }
            //변수 선언 및 입력 끝--------------------------

            for(int i=min; i<=max; i++)
            {
                int time = 0; //높이 i로 맞출 때 걸린 시간
                int inventory = b; //인벤토리에 갖고있는 블록의 수

                for(int j=0; j<n; j++)
                {
                    for(int k=0; k<m; k++)
                    {
                        int diff = blocks[j, k] - i;
                        int absDiff = Math.Abs(diff);

                        //블록을 제거해야 하는 경우
                        if(diff > 0)
                        {
                            time += absDiff * 2;
                            inventory += absDiff;
                        }
                        //블록을 추가해야 하는 경우
                        else if(diff < 0)
                        {
                            time += absDiff;
                            inventory -= absDiff;
                        }
                    }
                }

                //인벤토리에 존재하는 블록의 갯수가 음수가되는 경우는
                //불가능한 경우라는 의미임.
                if(inventory >= 0)
                {
                    //최소시간인지 판별, 같은 경우도 포함해야 최대 높이를 찾을 수 있다.
                    if(time <= minTime)
                    {
                        minTime = time;
                        //뒤로갈수록 블록이 높은 경우를 따지기 때문에 무조건 더 높다.
                        //고로 비교없이 그대로 대입해주어도 된다.
                        maxHeight = i;
                    }
                }
            }

            Console.WriteLine(minTime + " " + maxHeight);
        }
    }
}
