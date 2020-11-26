using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    
    class _2675
    {
        static void Main(string[] args)
        {
            int m_testCase = int.Parse(Console.ReadLine());

            for(int i=0; i<m_testCase; i++)
            {
                int iter = Console.Read() - '0';
                Console.Read();
                string str = Console.ReadLine();

                //스트링빌더★
                StringBuilder output = new StringBuilder();

                for (int j=0; j<str.Length; j++)
                {
                    output.Append(str[j], iter);
                }

                Console.WriteLine(output.ToString());
            }
        }
    }
    
}
