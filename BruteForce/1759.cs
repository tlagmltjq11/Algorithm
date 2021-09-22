using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1759
    {
        static List<string> answer = new List<string>();
        static int L, C;

        static void DFS(string[] alpha, StringBuilder temp, int index)
        {
            if(temp.ToString().Length == L)
            {
                string str = temp.ToString();
                bool vowel = false;
                int constant = 0;
                for(int i=0; i<L; i++)
                {
                    if(str[i].Equals('a') || str[i].Equals('e') || str[i].Equals('i') || str[i].Equals('o') || str[i].Equals('u'))
                    {
                        vowel = true;
                    }
                    else
                    {
                        constant++;
                    }
                }

                if(vowel && constant >= 2)
                {
                    answer.Add(str);
                }

                return;
            }

            for(int i=index; i<C; i++)
            {
                temp.Append(alpha[i]);
                DFS(alpha, temp, i + 1);
                temp.Replace(alpha[i], "");
            }
        }

        static void Main()
        {
            string[] temp = Console.ReadLine().Split(" ");
            L = int.Parse(temp[0]);
            C = int.Parse(temp[1]);

            temp = Console.ReadLine().Split(" ");
            Array.Sort(temp);

            DFS(temp, new StringBuilder(), 0);

            for(int i=0; i<answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }
    }
}
