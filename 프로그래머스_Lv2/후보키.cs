using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 후보키
    {
        static int cnt = 0;
        static string[,] table;

        static void Combination(int depth, List<int> keys)
        {
            if(depth == table.GetLength(1))
            {
                return;
            }

            for(int i=depth; i<table.GetLength(1); i++)
            {
                keys.Add(i);
                if(IsKey(keys))
                {
                    cnt++;
                    keys.Remove(i);
                    continue;
                }

                Combination(i + 1, keys);
                keys.Remove(i);
            }
        }

        static bool IsKey(List<int> keys)
        {
            HashSet<string> set = new HashSet<string>();

            for(int i=0; i<table.GetLength(0); i++)
            {
                string temp = string.Empty;

                for(int j=0; j<keys.Count; j++)
                {
                    temp += table[i, keys[j]];
                }

                if(set.Contains(temp))
                {
                    return false;
                }

                set.Add(temp);
            }

            return true;
        }

        static int solution(string[,] relation)
        {
            int answer = 0;
            table = relation;

            Combination(0, new List<int>());

            answer = cnt;
            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(new string[,] {{"100", "r" },
{ "200", "c" },
{ "300", "d" } }));
        }
    }
}
