using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingTestPractice
{
    class 풍선_터트리기
    {
        static int solution(int[] a)
        {
            int answer = 0;
            int[] leftMin = new int[1000001];
            int[] rightMin = new int[1000001];

            //특정 풍선 위치에서 좌측의 최소값을 DP로 구해 놓는다.
            leftMin[0] = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if(a[i] < leftMin[i - 1])
                {
                    leftMin[i] = a[i];
                }
                else
                {
                    leftMin[i] = leftMin[i - 1];
                }
            }

            //특정 풍선 위치에서 우측의 최소값을 DP로 구해 놓는다.
            rightMin[a.Length - 1] = a[a.Length - 1];
            for(int i=a.Length - 2; i >= 0; i--)
            {
                if(a[i] < rightMin[i + 1])
                {
                    rightMin[i] = a[i];
                }
                else
                {
                    rightMin[i] = rightMin[i + 1];
                }
            }

            //i번째 위치한 풍선 기준 좌,우측의 최소값(DP)이 모두 i번쨰 풍선보다 작다면
            //작은 풍선은 1번만 터트릴 수 있으므로 최후까지 남을 수 없다.
            for(int i=0; i<a.Length; i++)
            {
                //모든 풍선의 수는 다른데 같은 경우는 맨 왼쪽, 맨 오른쪽 풍선인 경우임.
                if(a[i] <= leftMin[i] || a[i] <= rightMin[i])
                {
                    answer++;
                }
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(new int[] { -16, 27, 65, -2, 58, -92, -71, -68, -61, -33 }));
        }
    }
}
