using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    //슬슬 c언어로 갈아타야할듯..
    class _7568
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            List<KeyValuePair<int, int>> m_list = new List<KeyValuePair<int, int>>();
            int[] m_compare = new int[N];

            for(int i=0; i<N; i++)
            {
                string[] inputs = Console.ReadLine().Split(" ");
                m_list.Add(new KeyValuePair<int, int>(int.Parse(inputs[0]), int.Parse(inputs[1])));
            }

            for(int i=0; i<N; i++)
            {
                var kvp = m_list[i];

                for(int j=i+1; j<N; j++)
                {
                    //i가 덩치가 큰 경우
                    if(kvp.Key > m_list[j].Key && kvp.Value > m_list[j].Value)
                    {
                        m_compare[j]++;
                    }
                    //j가 덩치가 큰 경우
                    else if(kvp.Key < m_list[j].Key && kvp.Value < m_list[j].Value)
                    {
                        m_compare[i]++;
                    }
                }
            }

            for(int i=0; i<N; i++)
            {
                Console.Write(m_compare[i] + 1);
                Console.Write(" ");
            }
        }
    }
}
