using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class _9375
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> m_dict = new Dictionary<string, int>();
            StringBuilder sb = new StringBuilder();

            for(int i=0; i<n; i++)
            {
                int line = int.Parse(Console.ReadLine());
                for(int j=0; j<line; j++)
                {
                    string[] read = Console.ReadLine().Split(" ");
                    
                    if(m_dict.ContainsKey(read[1]))
                    {
                        m_dict[read[1]]++;
                    }
                    else
                    {
                        m_dict.Add(read[1], 1);
                    }
                }

                int result = 1;
                foreach(KeyValuePair<string, int> item in m_dict)
                {
                    result *= (m_dict[item.Key] + 1);
                }
                result--;

                sb.AppendLine(result.ToString());

                m_dict.Clear();
            }

            Console.WriteLine(sb.ToString());
        }
    }
    */
}
