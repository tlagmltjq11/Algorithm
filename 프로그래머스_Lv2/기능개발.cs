using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 기능개발
    {

        static int[] solution(int[] progresses, int[] speeds)
        {
            int[] answer = new int[100];

            //남은 작업일 수를 저장할 큐
            Queue<int> days = new Queue<int>();

            //각 작업마다 남은 작업 일 수를 스피드로 나누어 구한다.
            for(int i=0; i<progresses.Length; i++)
            {
                double temp = 100 - progresses[i];
                temp = temp / speeds[i];

                if(temp - (int)temp > 0)
                {
                    temp++;
                    days.Enqueue((int)temp);
                }
                else
                {
                    days.Enqueue((int)temp);
                }
            }

            int cnt = 1;
            int iter = days.Dequeue();

            List<int> answerList = new List<int>();

            while(days.Count != 0)
            {
                if(days.Peek() > iter)
                {
                    answerList.Add(cnt);
                    cnt = 1;

                    iter = days.Dequeue();

                    if(days.Count == 0)
                    {
                        answerList.Add(1);
                        break;
                    }
                }
                else
                {
                    cnt++;
                    days.Dequeue();

                    if (days.Count == 0)
                    {
                        answerList.Add(cnt);
                        break;
                    }
                }
            }

            for(int i=0; i<answerList.Count; i++)
            {
                answer[i] = answerList[i];
            }

            return answer;
        }

        static void Main()
        {
            int[] progresses = { 95, 90, 99, 99, 80, 99 };
            int[] speeds = { 1, 1, 1, 1, 1, 1 };

            int[] ans = solution(progresses, speeds);

            for(int i=0; i<ans.Length; i++)
            {
                Console.WriteLine(ans[i]);
            }
        }
    }
}
