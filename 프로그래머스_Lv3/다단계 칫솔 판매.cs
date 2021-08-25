using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingTestPractice
{
    class 다단계_칫솔_판매
    {
        static Dictionary<string, int> m_empTotalRev = new Dictionary<string, int>();
        static Dictionary<string, string> m_empRef = new Dictionary<string, string>();
        static void CalcRevenue(string employee, int money)
        {
            //부모노드가 없거나 money가 0이면 계산 할 것이 없음.
            if(employee.Equals("-") || money < 1)
            {
                return;
            }

            int temp = (int)MathF.Ceiling(money / 10); //소수 첫째자리 올림

            m_empTotalRev[employee] += (money - temp); //판매한 칫솔 가격의 10%를 떼고 더해줌
            CalcRevenue(m_empRef[employee], temp);
        }

        static int[] solution(string[] enroll, string[] referral, string[] seller, int[] amount)
        {
            int[] answer;

            for(int i=0; i<enroll.Length; i++)
            {
                //자식-부모 관계 저장
                m_empRef.Add(enroll[i], referral[i]);
                m_empTotalRev.Add(enroll[i], 0);
            }


            for(int i=0; i<seller.Length; i++)
            {
                CalcRevenue(seller[i], amount[i] * 100);
            }

            answer = m_empTotalRev.Values.ToArray<int>();
            return answer;
        }

        static void Main()
        {
            int[] result = solution(new string[] {"john", "mary", "edward", "sam", "emily", "jaimie", "tod", "young" },
                new string[] { "-", "-", "mary", "edward", "mary", "mary", "jaimie", "edward" },
                new string[] {"young", "john", "tod", "emily", "mary"},
                new int[] { 12, 4, 2, 5, 10 });

            for(int i=0; i<result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
