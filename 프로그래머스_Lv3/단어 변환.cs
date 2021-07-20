using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 단어_변환
    {
        static bool[] visited;

        static bool CanTranslate(string from, string to)
        {
            int cnt = 0;

            for(int i=0; i<from.Length; i++)
            {
                if(!from[i].Equals(to[i]))
                {
                    cnt++;

                    if(cnt > 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static int solution(string begin, string target, string[] words)
        {
            int answer = 0;
            int size = words.Length;
            visited = new bool[size];

            Queue<KeyValuePair<string, int>> q = new Queue<KeyValuePair<string, int>>();

            q.Enqueue(new KeyValuePair<string, int>(begin, 0));

            while(q.Count != 0)
            {
                KeyValuePair<string, int> temp = q.Dequeue();

                if(temp.Key.Equals(target))
                {
                    answer = temp.Value;
                    return answer;
                }

                for(int i=0; i<size; i++)
                {
                    if(visited[i] != true && CanTranslate(temp.Key, words[i]))
                    {
                        visited[i] = true;
                        q.Enqueue(new KeyValuePair<string, int>(words[i], temp.Value + 1));
                    }
                }
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log", "cog"}));
        }
    }
}
