using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _110_옮기기
    {
        static string ooz = "110";

        static string solve(string s)
        {
            StringBuilder sb = new StringBuilder();
            Stack<char> stack = new Stack<char>();

            // 110의 갯수
            int cnt = 0;

            for (int i = 0; i < s.Length; i++)
            {
                stack.Push(s[i]);

                if (stack.Count >= 3)
                {
                    char first = stack.Pop();
                    if (first != '0')
                    {
                        stack.Push(first);
                        continue;
                    }
                    char second = stack.Pop();
                    if (second != '1')
                    {
                        stack.Push(second);
                        stack.Push(first);
                        continue;
                    }
                    char third = stack.Pop();
                    if (third != '1')
                    {
                        stack.Push(third);
                        stack.Push(second);
                        stack.Push(first);
                        continue;
                    }

                    // 110을 찾았다면 카운트
                    cnt++;
                }
            }

            int pos = stack.Count;
            bool flag = false;

            //0을 발견할때까지 idx조정
            while (stack.Count != 0)
            {
                char pop = stack.Pop();
                if (!flag && pop == '1')
                {
                    pos--;
                }

                if (pop == '0')
                {
                    flag = true;
                }

                sb.Insert(0, pop);
            }

            //110의 갯수만큼 110을 idx자리에 붙힘
            for (int j = 0; j < cnt; j++)
            {
                sb.Insert(pos, ooz);
            }

            return sb.ToString();
        }

        static string[] solution(string[] s)
        {

            string[] answer = new string[s.Length];
            for(int i=0; i<s.Length; i++)
            {
                answer[i] = solve(s[i]);
            }

            return answer;

                            /*
                while(stack.Count != 0)
                {
                    sb.Insert(0, stack.Pop());
                }

                s[i] = sb.ToString();
                sb.Clear();
                stack.Clear();

                while (s[i].Contains(ooz)) // 110이 존재한다면 반복
                {
                    cnt++; // 110의 갯수 카운트
                    int index = s[i].IndexOf(ooz); // 110 인덱스 찾기

                    sb.Append(s[i].Substring(0, index)); // 110 떼어내고 왼쪽
                    if(s[i].Length > index + 3)
                    {
                        sb.Append(s[i].Substring(index + 3)); // 110 떼어내고 오른쪽
                    }

                    s[i] = sb.ToString(); // s[i]에서 110을 떼어 낸 문자열로 변경
                    sb.Clear(); // sb 초기화
                }

                for(int iter = 0; iter < cnt; iter++)
                {
                    bool check = false;
                    for (int j = 0; j < s[i].Length; j++)
                    {
                        // 0을 발견한 경우
                        if (s[i][j].Equals('0'))
                        {
                            check = true;

                            // 0이 맨 마지막 원소일 경우
                            if(j+1 == s[i].Length)
                            {
                                sb.Append(s[i]).Append(ooz);
                                s[i] = sb.ToString();
                                sb.Clear();
                                break;
                            }

                            // 0 한칸 뒤에 숫자가 존재할 경우
                            if(j+1 < s[i].Length)
                            {
                                if(s[i][j + 1].Equals('0'))
                                {
                                    continue;
                                }
                            }

                            // 0 두칸 뒤에 숫자가 존재할 경우
                            if (j+2 < s[i].Length)
                            {
                                if (s[i][j + 2].Equals('0'))
                                {
                                    continue;
                                }
                            }

                            sb.Append(s[i].Substring(0, j + 1)).Append(ooz).Append(s[i].Substring(j + 1));
                            s[i] = sb.ToString();
                            sb.Clear();
                            break;
                        }
                    }

                    // 0이 없던 경우
                    if(check == false)
                    {
                        sb.Append(ooz).Append(s[i]);
                        s[i] = sb.ToString();
                        sb.Clear();
                    }
                }*/
            
        }

        static void Main()
        {
            string[] result = solution(new string[] { "1110", "100111100", "0111111010" });
            
            for(int i=0; i<result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
