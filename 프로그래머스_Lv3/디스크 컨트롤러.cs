using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 디스크_컨트롤러
    {
        public class Job
        {
            public int requestTime;
            public int taskTime;

            public Job(int requestTime, int taskTime)
            {
                this.requestTime = requestTime;
                this.taskTime = taskTime;
            }
        }

        static int solution(int[,] jobs)
        {
            int answer = 0;

            List<Job> list = new List<Job>();
            int size = jobs.GetLength(0);

            for (int i = 0; i < jobs.GetLength(0); i++)
            {
                list.Add(new Job(jobs[i, 0], jobs[i, 1]));
            }

            list.Sort((a, b) =>
            {
                int temp = a.requestTime - b.requestTime;
                if (temp == 0)
                {
                    //요청시간이 같은 경우 작업시간으로 정렬
                    temp = a.taskTime - b.taskTime;
                    return temp;
                }
                return temp;
            });

            int curEnd = 0;
            while (list.Count != 0)
            {
                Job next = null;

                for (int i = 0; i < list.Count; i++)
                {
                    //현재 끝나는 시간 이전에 요청된 작업들만 처리하기 위한 break문
                    if(list[i].requestTime > curEnd)
                    {
                        break;
                    }

                    if(next == null)
                    {
                        next = list[i];
                    }
                    else
                    {
                        if(list[i].taskTime < next.taskTime)
                        {
                            next = list[i];
                        }
                    }
                }

                //curEnd 이전에 요청된 작업이 하나도 없다면 곧바로 제일 빠르게 요청된 작업을 next로 할당
                if(next == null)
                {
                    next = list[0];
                }

                int delay = curEnd - next.requestTime; //작업이 시작되기 까지 딜레이
                int ms = Math.Max(delay, 0) + next.taskTime; //총 대기시간
                curEnd += delay < 0 ? Math.Abs(delay) + next.taskTime : next.taskTime;
                answer += ms;
                list.Remove(next);
            }

            return answer / size;
        }

        static void Main()
        {
            Console.Write(solution(new int[,] {{24, 10}, {28, 39}, {43, 20}, {37, 5}, {47, 22}, {20, 47}, {15, 34}, {15, 2}, {35, 43}, {26, 1} }));
        }
    }
}
