using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _10815
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] card = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), (s) => int.Parse(s));

            int q = int.Parse(Console.ReadLine());
            int[] question = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), (s) => int.Parse(s));

            List<int> answer = new List<int>();

            Array.Sort(card);
            for(int i=0; i<q; i++)
            {
                int cur = question[i];

                bool check = false;
                int left = 0;
                int right = card.Length-1;
                
                while(left <= right)
                {
                    int mid = (left + right) / 2;

                    if(card[mid] == cur)
                    {
                        check = true;
                        break;
                    }
                    else if(card[mid] > cur)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }

                if(!check)
                {
                    answer.Add(0);
                }
                else
                {
                    answer.Add(1);
                }
            }

            StringBuilder sb = new StringBuilder();
            for(int i=0; i<answer.Count; i++)
            {
                sb.Append(answer[i].ToString() + " ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
