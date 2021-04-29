using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 프린터
    {
        static int solution(int[] priorities, int location)
        {
            int answer = 0;

            Queue<KeyValuePair<int, int>> q = new Queue<KeyValuePair<int, int>>();

            for(int i=0; i<priorities.Length; i++)
            {
                q.Enqueue(new KeyValuePair<int, int>(priorities[i], i));
            }

            int order = 0;
            KeyValuePair<int, int> cur;

            while(q.Count != 0)
            {
                cur = q.Dequeue();

                bool check = false;

                //q는 인덱스를 통한 접근이 안되므로 foreach
                foreach (KeyValuePair<int, int> v in q)
                {
                    if (v.Key > cur.Key)
                    {
                        check = true;
                        q.Enqueue(cur);
                        break;
                    }
                }

                if(!check)
                {
                    order++;

                    if(cur.Value == location)
                    {
                        return order;
                    }
                }
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(new int[] { 1,1,9,1,1,1 }, 0));
        }
    }
}
