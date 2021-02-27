using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _17298
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            string[] read = Console.ReadLine().Split(" ");
            int[] seq = Array.ConvertAll<string, int>(read, s => int.Parse(s));

            for(int i=0; i<n; i++)
            {
                while(stack.Count != 0 && seq[stack.Peek()] < seq[i])
                {
                    seq[stack.Pop()] = seq[i];
                }

                stack.Push(i);
            }

            while (stack.Count != 0)
            {
                seq[stack.Pop()] = -1;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                sb.Append(seq[i] + " ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
