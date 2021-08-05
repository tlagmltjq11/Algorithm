using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 여행경로
    {
        static List<KeyValuePair<string, string>> temp = new List<KeyValuePair<string, string>>();
        static bool[] visited;
        static List<string> answer = new List<string>();

        static bool DFS(string start, int depth)
        {
            if(depth == visited.Length)
            {
                return true;
            }

            for(int i=0; i<temp.Count; i++)
            {
                if(temp[i].Key == start && !visited[i])
                {
                    visited[i] = true;
                    answer.Add(temp[i].Value);

                    if(DFS(temp[i].Value, depth + 1))
                    {
                        return true;
                    }

                    visited[i] = false;
                }
            }

            answer.RemoveAt(answer.Count - 1);
            return false;
        }

        static string[] solution(string[,] tickets)
        {
            for(int i=0; i<tickets.GetLength(0); i++)
            {
                temp.Add(new KeyValuePair<string, string>(tickets[i, 0], tickets[i, 1]));
            }

            temp.Sort((a,b) => 
            {
                int result = a.Key.CompareTo(b.Key);
                if(result == 0)
                {
                    return a.Value.CompareTo(b.Value);
                }
                return result;
            });

            visited = new bool[temp.Count];

            answer.Add("ICN");
            DFS("ICN", 0);

            return answer.ToArray();
        }

        static void Main()
        {
            string[] result = solution(new string[,] {{ "ICN", "B" },{ "B", "ICN" },{ "ICN", "A" }, {"A", "D" },{ "D", "A" } });


            for (int i=0; i<result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
