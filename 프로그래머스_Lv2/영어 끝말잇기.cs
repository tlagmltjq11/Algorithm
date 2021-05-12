using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 영어_끝말잇기
    {
        static bool check(string before, string cur)
        {
            if(before[before.Length-1].Equals(cur[0]))
            {
                return true;
            }

            return false;
        }

        static int[] solution(int n, string[] words)
        {
            int[] answer = {0,0};

            int cnt = 2;
            int turn = 1;


            HashSet<string> set = new HashSet<string>();

            set.Add(words[0]);
            for(int i=1; i<words.Length; i++)
            {
                if (set.Contains(words[i]) || !check(words[i-1], words[i]))
                {
                    return new int[] { cnt, turn };
                }
                else
                {
                    set.Add(words[i]);
                }

                cnt++;

                if (cnt > n)
                {
                    cnt = 1;
                    turn++;
                }
            }

            return answer;
        }

        static void Main()
        {
            int[] temp = solution(2, new string[] { "hello", "one", "even", "never", "now", "world", "draw" });

            Console.WriteLine(temp[0]);
            Console.WriteLine(temp[1]);
        }
    }
}
