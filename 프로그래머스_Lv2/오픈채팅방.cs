using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 오픈채팅방
    {
        static string[] solution(string[] record)
        {
            string[] answer = { };
            List<string> temp = new List<string>();

            Dictionary<string, string> users = new Dictionary<string, string>();

            for(int i=0; i<record.Length; i++)
            {
                string[] cur = record[i].Split(" ");

                if(cur[0].Equals("Leave"))
                {
                    continue;
                }

                string userId = cur[1];
                string nickName = cur[2];

                if(users.ContainsKey(userId))
                {
                    users[userId] = nickName;
                }
                else
                {
                    users.Add(userId, nickName);
                }
            }

            for(int i=0; i<record.Length; i++)
            {
                string[] cur = record[i].Split(" ");
                string log = cur[0];
                string userId = cur[1];

                if(log.Equals("Enter"))
                {
                    temp.Add(users[userId] + "님이 들어왔습니다.");
                }
                else if(log.Equals("Leave"))
                {
                    temp.Add(users[userId] + "님이 나갔습니다.");
                }
                else
                {
                    //error
                }
            }

            answer = temp.ToArray();

            return answer;
        }

        static void Main()
        {
            string[] result = solution(new string[] { "Enter uid1234 Muzi", "Enter uid4567 Prodo", "Leave uid1234", "Enter uid1234 Prodo", "Change uid4567 Ryan" });

            for(int i=0; i<result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
