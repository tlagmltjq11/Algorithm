using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class Sorter : IComparer<string>
    {
        int IComparer<string>.Compare(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return 1;
            }
            else if (a.Length < b.Length)
            {
                return -1;
            }
            else
            {
                return a.CompareTo(b);
            }
        }
    }

    class _1181
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            string[] datas = new string[n];

            for(int i=0; i<n; i++)
            {
                datas[i] = Console.ReadLine();
            }

            Array.Sort(datas, new Sorter());

            sb.AppendLine(datas[0]);
            for(int i=1; i<n; i++)
            {
                if(!datas[i-1].Equals(datas[i]))
                {
                    sb.AppendLine(datas[i]);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
    */
}
