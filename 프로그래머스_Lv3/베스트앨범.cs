using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 베스트앨범
    {
        static int[] solution(string[] genres, int[] plays)
        {
            int[] answer;
            List<int> answerList = new List<int>();
            Dictionary<string, List<KeyValuePair<int, int>>> dict = new Dictionary<string, List<KeyValuePair<int, int>>>(100);
            
            for(int i=0; i<plays.Length; i++)
            {
                if(!dict.ContainsKey(genres[i]))
                {
                    dict.Add(genres[i], new List<KeyValuePair<int, int>>());
                    dict[genres[i]].Add(new KeyValuePair<int, int>(i, plays[i]));
                }
                else
                {
                    dict[genres[i]].Add(new KeyValuePair<int, int>(i, plays[i]));
                }
            }

            foreach(var k in dict.Keys)
            {
                //원소가 2개 미만이면 정렬할 필요가 없으므로 다음 반복으로 넘어간다.
                if(dict[k].Count < 2)
                {
                    continue;
                }

                //각 리스트에 포함된 곡들을 조건에 맞게 정렬
                dict[k].Sort( (a,b) =>
                {
                    int temp = a.Value - b.Value;
                    if(temp == 0)
                    {
                        temp = a.Key - b.Key;
                        return temp;
                    }
                    return -temp;
                });
            }

            List<KeyValuePair<string, int>> sortList = new List<KeyValuePair<string, int>>();
            
            foreach(var k in dict.Keys)
            {
                int temp = 0;

                //각 장르별 총 플레이 수를 구함.
                for(int i=0; i<dict[k].Count; i++)
                {
                    temp += dict[k][i].Value;
                }

                sortList.Add(new KeyValuePair<string, int>(k, temp));
            }

            //총 플레이 수를 이용해 장르리스트를 정렬.
            sortList.Sort((a, b) =>
            {
                int temp = a.Value - b.Value;
                return -temp;
            });

            //각 장르별 최대 플레이 2곡씩 추가.
            for(int i=0; i<sortList.Count; i++)
            {
                //첫번째 곡을 넣고 삭제
                answerList.Add(dict[sortList[i].Key][0].Key);
                dict[sortList[i].Key].RemoveAt(0);

                //다음 곡이 존재하는 경우 해당 곡을 넣는다.
                if (dict[sortList[i].Key].Count != 0)
                {
                    answerList.Add(dict[sortList[i].Key][0].Key);
                }
            }

            answer = answerList.ToArray();
            return answer;
        }

        static void Main()
        {
            int[] result = solution(new string[] { "classic", "pop", "classic", "classic", "pop" }, new int[] { 500, 600, 150, 800, 2500 });

            for(int i=0; i<result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
