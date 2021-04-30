using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 문자열_압축
    {
        static int solution(string s)
        {
            int answer = 1001;

            for(int i=1; i <= s.Length / 2; i++)
            {
                int cnt = 1;
                string result = "";
                string temp = s.Substring(0, i);

                for(int j=i; j<=s.Length; j += i)
                {
                    if((j + i) > s.Length)
                    {
                        if(cnt == 1)
                        {
                            result += temp;
                            result += s.Substring(j);
                        }
                        else
                        {
                            result += cnt.ToString() + temp;
                            result += s.Substring(j);
                        }

                        break;
                    }

                    string iter = s.Substring(j, i);
                    if (!temp.Equals(iter))
                    {
                        if(cnt == 1)
                        {
                            result += temp;
                        }
                        else
                        {
                            result += cnt.ToString() + temp;
                        }

                        temp = iter;
                        cnt = 1;
                    }
                    else
                    {
                        cnt++;
                    }
                }
                answer = Math.Min(answer, result.Length);
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution("xababcdcdababcdcd"));
        }
    }
}
