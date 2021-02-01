using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2108
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int[] nums = new int[N];
            int[] cnts = new int[8001];
            bool check = false;
            int freq = 0, val;
            double avg = 0;

            for(int i=0; i<N; i++)
            {
                val = int.Parse(Console.ReadLine()); //입력받은 수
                nums[i] = val; //배열에 저장

                avg += val; //산술평균을 위해 곧바로 더해준다.

                cnts[val + 4000]++;
            }

            Array.Sort(nums);

            avg = avg / N;
            avg = Math.Round(avg);

            for(int i=0; i<8001; i++)
            {
                if(cnts[freq] < cnts[i])
                {
                    freq = i;
                }
            }

            for(int i=freq + 1; i<8001; i++)
            {
                if(cnts[i] == cnts[freq])
                {
                    freq = i;
                    break;
                }
            }

            sb.AppendLine(avg.ToString()); //산술평균
            sb.AppendLine(nums[N / 2].ToString()); //중앙값
            sb.AppendLine((freq-4000).ToString()); //최빈값
            sb.AppendLine((nums[N - 1] - nums[0]).ToString()); //범위

            Console.WriteLine(sb);
        }
    }
}
