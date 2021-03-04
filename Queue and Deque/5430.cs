using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingTestPractice
{
    class _5430
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string func = Console.ReadLine();
                int size = int.Parse(Console.ReadLine());

                if (size == 0)
                {
                    sb.AppendLine("error");
                    continue;
                }

                string nums = Console.ReadLine();
                List<string> list;

                nums = nums.Replace("[", "");
                nums = nums.Replace("]", "");

                string[] temp = nums.Split(",");
                list = temp.ToList<string>();

                func = func.Replace("RR", "");

                int cur = 0;
                int rCnt = 0;
                bool check = false;
                for (int j = 0; j < func.Length; j++)
                {
                    if (func[j] == 'R')
                    {
                        rCnt++;

                        if (cur == 0)
                        {
                            cur = list.Count - 1;
                        }
                        else
                        {
                            cur = 0;
                        }
                    }
                    else if (func[j] == 'D')
                    {
                        if (list.Count == 0)
                        {
                            sb.AppendLine("error");
                            check = true;
                            break;
                        }
                        else
                        {
                            if (cur != 0)
                            {
                                cur = list.Count - 1;
                            }

                            list.RemoveAt(cur);
                        }
                    }
                }

                if (check == false)
                {
                    sb.Append("[");
                    if (rCnt % 2 == 0)
                    {
                        for (int j = 0; j < list.Count; j++)
                        {
                            sb.Append(list[j]);

                            if (j != list.Count - 1)
                            {
                                sb.Append(",");
                            }
                        }
                    }
                    else
                    {
                        for (int j = list.Count - 1; j >= 0; j--)
                        {
                            sb.Append(list[j]);

                            if (j != 0)
                            {
                                sb.Append(",");
                            }
                        }
                    }
                    sb.AppendLine("]");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
