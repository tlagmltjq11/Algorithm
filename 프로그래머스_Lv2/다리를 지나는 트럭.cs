using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 다리를_지나는_트럭
    {
        static int solution(int bridge_length, int weight, int[] truck_weights)
        {
            int answer = 0;

            Queue<int> truck_On_Bridge = new Queue<int>();
            Queue<int> time = new Queue<int>();

            int cur = 1;
            int end = 0;
            int iter = 1;

            truck_On_Bridge.Enqueue(truck_weights[0]);
            time.Enqueue(1);
            int curWeight = truck_weights[0];

            while (end != truck_weights.Length)
            {
                cur++;

                //맨앞의 트럭이 다리를 건너간 경우
                if(cur - time.Peek() == bridge_length)
                {
                    curWeight -= truck_On_Bridge.Dequeue();
                    time.Dequeue();
                    end++;
                }

                //다음 트럭이 다리에 올라탈 수 있는 경우
                if(iter < truck_weights.Length)
                {
                    if (truck_weights[iter] + curWeight <= weight)
                    {
                        curWeight += truck_weights[iter];
                        truck_On_Bridge.Enqueue(truck_weights[iter]);
                        time.Enqueue(cur);
                        iter++;
                    }
                }
            }

            answer = cur;

            return answer;
        }

        static void Main()
        {
            int ans = solution(2, 10, new int[] { 7,4,5,6});
            Console.WriteLine(ans);
        }
    }
}
