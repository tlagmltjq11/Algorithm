using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingTestPractice
{
    class 메뉴_리뉴얼
    {
        static Dictionary<string, int> dict = new Dictionary<string, int>();
        static int[] lengths;

        static bool lenCheck(string str)
        {
            for(int i=0; i<lengths.Length; i++)
            {
                if(str.Length == lengths[i])
                {
                    return true;
                }
            }

            return false;
        }

        static void Permutation(int depth, int size, string order, string cur)
        {
            if(lenCheck(cur))
            {
                if(dict.ContainsKey(cur))
                {
                    dict[cur]++;
                }
                else
                {
                    dict.Add(cur, 1);
                }
            }

            for(int i=depth; i<size; i++)
            {
                cur += order[i];
                Permutation(i + 1, size, order, cur);
                cur = cur.Substring(0, cur.Length - 1);
            }

            return;
        }

        static string[] solution(string[] orders, int[] course)
        {
            string[] answer = { };
            List<string> temp = new List<string>();

            lengths = course;


            for (int i=0; i<orders.Length; i++)
            {
                //orders 문자열은 내부 정렬이 안되어있기 때문에 전부 정렬 후 매개변수로 넘겨줘야 한다.
                Permutation(0, orders[i].Length, new string(orders[i].ToCharArray().OrderBy(x => x).ToArray()), new string(""));
            }

            for(int i=0; i<course.Length; i++)
            {
                int maxVal = 0;

                foreach (var kv in dict)
                {
                    if (kv.Key.Length == course[i] && kv.Value > maxVal)
                    {
                        maxVal = kv.Value;
                    }
                }

                if(maxVal < 2)
                {
                    continue;
                }

                foreach (var kv in dict)
                {
                    if (kv.Value == maxVal && kv.Key.Length == course[i])
                    {
                        temp.Add(kv.Key);
                    }
                }
            }

            temp.Sort();
            answer = temp.ToArray();

            return answer;
        }

        static void Main()
        {
            string[] result = solution(new string[] { "XYZ", "XWY", "WXA" }, new int[] { 2, 3, 4 });

            for(int i=0; i<result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
